using Microsoft.AspNetCore.Mvc;
using PhamHaiMinh_241230797.Models;
using Microsoft.EntityFrameworkCore;

namespace PhamHaiMinh_241230797.ViewComponents
{
    public class CheckGiaViewComponent:ViewComponent
    {
        private readonly QltaiSanContext _context;
        public CheckGiaViewComponent(QltaiSanContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var TaiSan = await _context.TaiSans.Where(t => t.NguyenGia >= 20).ToListAsync();
            return View(TaiSan);
        }
    }
}
