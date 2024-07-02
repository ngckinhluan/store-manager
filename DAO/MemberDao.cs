using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Entities;

namespace DAO
{
    public class MemberDao
    {
        private readonly StoremanagementContext _context = null;

        public MemberDao()
        {
            if (_context == null)
            {
                _context = new StoremanagementContext();
            }
        }

        public List<Member> GetMembers()
        {
            return _context.Members.ToList();
        }

        public Member GetMemberById(int id)
        {
            return _context.Members.Find(id);
        }

        public Member AddMember(Member member)
        {
            _context.Members.Add(member);
            _context.SaveChanges();
            return member;
        }

        public Member UpdateMember(int id, Member member)
        {
            var existingMember = GetMemberById(id);
            if (existingMember != null)
            {
                existingMember.CompanyName = member.CompanyName;
                existingMember.Email = member.Email;
                _context.Members.Update(existingMember);
                _context.SaveChanges();
            }
            return existingMember;
        }

        public void DeleteMember(int id)
        {
            var member = GetMemberById(id);
            if (member != null)
            {
                _context.Members.Remove(member);
                _context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException("Member not found");
            }
        }
    }
}
