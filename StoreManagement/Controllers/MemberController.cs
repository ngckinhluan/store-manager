using BusinessObjects.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Implementation;
using Services.Interface;

namespace StoreManagement.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MemberController : ControllerBase
{
    private readonly IMemberService _memberService = null;

    public MemberController()
    {
        _memberService ??= new MemberService();
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Member>>> GetMembers()
    {
        if (_memberService.GetMembers() != null) return _memberService.GetMembers().ToList();
        return NotFound();
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<Member>> GetMember(int id)
    {
        if (_memberService.GetMembers() == null) NotFound();
        var member = _memberService.GetMemberById(id);
        if (member == null) return NotFound(); 
        return member;
    }
    
    [HttpPut("UpdateMember")]
    public async Task<ActionResult<Member>> UpdateMember(int id, Member member)
    {
        if (id != member.MemberId) return BadRequest();
        _memberService.UpdateMember(id, member);
        return NoContent();
    }
    
    [HttpPost("AddNewMember")]
    public async Task<ActionResult<Member>> AddMember(Member member)
    {
        if (_memberService.GetMembers() == null) return Problem("Entity set 'OrchidContext.orchid' is null");
        _memberService.AddMember(member);
        return CreatedAtAction("GetMember", new { id = member.MemberId }, member);
    }

    [HttpDelete("DeleteMember")]
    public async Task<IActionResult> DeleteMember(int id)
    {
        if (_memberService.GetMembers() == null) return NotFound();
        _memberService.DeleteMember(id);
        return NoContent();
    }
}