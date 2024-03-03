using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RedFords_API.Data;
using RedFords_API.Models;
using RedFords_API.Models.DTO;
using System.Diagnostics;

namespace RedFords_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly APIDbContext _aPIDbContext;

        public StaffController(APIDbContext aPIDbContext)
        {
            _aPIDbContext = aPIDbContext;
        }

        [HttpGet]
        public IActionResult GetAll() 
        { 
            var staffdetails = _aPIDbContext.Staffs.ToList();
            var staffDto = new List<StaffDto>();
            foreach (var dsStaff in staffdetails)
            {
                staffDto.Add(new StaffDto()
                {
                    Id = dsStaff.Id,
                    Title = dsStaff.Title,
                    StaffType = dsStaff.StaffType,
                    FirstName = dsStaff.FirstName,
                    LastName = dsStaff.LastName,
                    MiddleInitial = dsStaff.MiddleInitial,
                    HomePhone = dsStaff.HomePhone,
                    CellPhone = dsStaff.CellPhone,
                    IRDNumber = dsStaff.IRDNumber,
                    OfficeExtension = dsStaff.OfficeExtension,
                    ManagerId = dsStaff.ManagerId
                });
            }
            return Ok(staffdetails);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetById(Guid Id) 
        { 
            var staff = _aPIDbContext.Staffs.FirstOrDefault(x => x.Id == Id);

            if(staff == null)
            {
                return NotFound();
            }

            var staffDto = new StaffDto
            {
                Id = staff.Id,
                Title = staff.Title,
                FirstName = staff.FirstName,
                LastName = staff.LastName,
                MiddleInitial  = staff.MiddleInitial,
                HomePhone = staff.HomePhone,
                CellPhone = staff.CellPhone,
                OfficeExtension = staff.OfficeExtension,
                IRDNumber= staff.IRDNumber,
                StaffType = staff.StaffType,
                ManagerId = staff.ManagerId                        
            };

            return Ok(staffDto);
        }

        [HttpPost]
        [Route("CreateStaff")]
        public IActionResult CreateStaff(Staff staff)
        {
            _aPIDbContext.Staffs.Add(staff);
            _aPIDbContext.SaveChanges();
            return Ok();
        }

        [HttpPut]
        [Route("Edit/{id:Guid}")]
        public IActionResult EditStaff(Guid id, Staff staff)
        {
            staff.Id = id;
            var staffDetails = _aPIDbContext.Staffs.Find(id);
            if(staffDetails == null)
            {
                return NotFound($"Staff details not found with this id: { staff.Id}");
            }

            staffDetails.StaffType = staff.StaffType;
            staffDetails.FirstName = staff.FirstName;
            staffDetails.LastName = staff.LastName;
            staffDetails.OfficeExtension = staff.OfficeExtension;
            staffDetails.Title = staff.Title;
            staffDetails.IRDNumber = staff.IRDNumber;
            staffDetails.CellPhone = staff.CellPhone;
            staffDetails.HomePhone = staff.HomePhone;
            staffDetails.MiddleInitial = staff.MiddleInitial;
            staffDetails.ManagerId = staff.ManagerId;
            _aPIDbContext.SaveChanges();
            return Ok();
        }

        
        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public IActionResult DeleteActivity(Guid id)
        {
            var staff = _aPIDbContext.Staffs.Find(id);
            if (staff == null)
            {
                return NotFound($"Staff details not found with this id: {id}");
            }

            _aPIDbContext.Staffs.Remove(staff);
            _aPIDbContext.SaveChanges();
            return Ok();
        }
    }
}
