using DeviceManagement_WebApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using DeviceManagement_WebApp.Models;

namespace DeviceManagement_WebApp.Repository
{
    public class DeviceRepository
    {
        private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

        // GET: Devices
        public async Task<IActionResult> Index()
        {
            DeviceRepository deviceRepository = new DeviceRepository();
            
            return (IActionResult)_context.Device.Include(d => d.Category).Include(d => d.Zone).ToList();
        }
        // GET: Devices/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            DeviceRepository deviceRepository = new DeviceRepository();


            return (IActionResult)_context.Device
                .Include(d => d.Category)
                .Include(d => d.Zone)
                .FirstOrDefaultAsync(m => m.DeviceId == id);
        }

    }
}
