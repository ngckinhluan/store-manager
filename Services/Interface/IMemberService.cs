using BusinessObjects.Entities;

namespace Services.Interface;

public interface IMemberService
{
    public List<Member> GetMembers();
    public Member GetMemberById(int id);
    public Member AddMember(Member member);
    public Member UpdateMember(int id, Member member);
    public void DeleteMember(int id);
}