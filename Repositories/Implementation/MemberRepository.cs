using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Entities;
using DAO;

namespace Repositories.Implementation
{
    public class MemberRepository : IMemberRepository
    {
        private readonly MemberDao _memberDao = null;
        public MemberRepository()
        {
            _memberDao ??= new MemberDao();
        }
        public List<Member> GetMembers()
        {
            return _memberDao.GetMembers();
        }

        public Member GetMemberById(int id)
        {
            return _memberDao.GetMemberById(id);
        }

        public Member AddMember(Member member)
        {
            throw new NotImplementedException();
        }

        public Member UpdateMember(int id, Member member)
        {
            throw new NotImplementedException();
        }

        public void DeleteMember(int id)
        {
            throw new NotImplementedException();
        }
    }
}
