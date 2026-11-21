using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhamHaiMinh_241230797.Models;

namespace PhamHaiMinh_241230797.ViewComponents
{
    public class MenuViewComponent:ViewComponent
    {
        private readonly QltaiSanContext _context;
        public MenuViewComponent(QltaiSanContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var loaiTaiSan = _context.LoaiTaiSans.OrderBy(t => t.MaLoai).ToList();
            return View(loaiTaiSan);
        }
    }
}
