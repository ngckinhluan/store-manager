using BusinessObjects.Entities;
using Repositories.Implementation;
using Services.Interface;

namespace Services.Implementation;

public class MemberService : IMemberService
{
    private readonly MemberRepository _memberRepository = null;

    public MemberService()
    {
        _memberRepository ??= new MemberRepository();
    }
    
    public List<Member> GetMembers()
    {
        return _memberRepository.GetMembers();
    }

    public Member GetMemberById(int id)
    {
        return _memberRepository.GetMemberById(id);
    }

    public Member AddMember(Member member)
    {
        return _memberRepository.AddMember(member);
    }

    public Member UpdateMember(int id, Member member)
    {
        return _memberRepository.UpdateMember(id, member);
    }

    public void DeleteMember(int id)
    {
        _memberRepository.DeleteMember(id);
    }
}