using ExtraaEdgeAssig.Data;
using ExtraaEdgeAssig.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;


namespace ExtraaEdgeAssig.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly ApplicationDbContext db;
        public ReportController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpGet("GetMonthlySalesReport")]
        public ActionResult GetMonthlySalesReport(DateTime fromDate,DateTime toDate)
        {
            var Purchases=(from p in db.Purchases
                           where p.PurchaseDate > fromDate && p.PurchaseDate < toDate select p ).ToList();
            var totalSales= Purchases.Sum(p => p.FinalPrice);
            return new ObjectResult(Purchases);
        }
        [HttpGet("salesreportbybrand")]

        public IActionResult GetSalesReportByBrand(DateTime fromDate,DateTime toDate)
        {
            var salesByBrand = from p in db.Purchases
                               join mob in db.Mobiles on p.Id equals mob.Id into MobilePurchase
                               where p.PurchaseDate > fromDate && p.PurchaseDate < toDate
                               select new
                               {
                                   purchaseDate = p.PurchaseDate,
                                   purPrice = p.PurPrice,
                                   discount = p.Discount,
                                   finalPrice = p.FinalPrice,
                               };
            return Ok(salesByBrand);

        }
        [HttpGet("profitlossreport")]
        public async Task<ActionResult<ProfitLoss>> GetProfitLossReport(DateTime fromDate,DateTime toDate)
        {
            var Purchases = await db.Purchases
                .Where(p => p.PurchaseDate >= fromDate && p.PurchaseDate <= toDate).ToListAsync();
            decimal totalSales = Purchases.Sum(p => p.FinalPrice);
            decimal totalDiscount=Purchases.Sum(p => p.Discount);
            decimal totalPurPrice = Purchases.Sum(p => p.PurPrice);

            var prevPurchases=await db.Purchases
                .Where(p=>p.PurchaseDate>=fromDate.AddYears(-1) && p.PurchaseDate<=toDate.AddYears(-1)).ToListAsync();

            decimal prevTotalSales=prevPurchases.Sum(p => p.FinalPrice);
            decimal prevTotalDiscount = prevPurchases.Sum(p => p.Discount);

            decimal profitloss = totalSales - totalDiscount - totalPurPrice;
            decimal prevProfitLoss = prevTotalSales - prevTotalDiscount - totalPurPrice;
            decimal diff = profitloss- prevProfitLoss;

            var res = new ProfitLoss
            {
                TotalSales = totalSales,
                TotalDiscount = totalDiscount,
                TotalPurPrice = totalPurPrice,
                Profitloss = profitloss - diff
            };
            return res;
        }
    }
}
