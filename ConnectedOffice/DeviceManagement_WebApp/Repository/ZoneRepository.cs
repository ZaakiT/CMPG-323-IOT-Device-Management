using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
namespace DeviceManagement_WebApp.Repository
{
    public class ZoneRepository
    {
        private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

        // GET: Zones
        public async Task<IActionResult> Index()
        {
            ZoneRepository zoneRepository = new ZoneRepository();
            return (IActionResult)_context.Zone.ToListAsync();
        }

    }
}
