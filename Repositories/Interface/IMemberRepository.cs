using BusinessObjects.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface IMemberRepository
    { 
        public List<Member> GetMembers();
        public Member GetMemberById(int id);
        public Member AddMember(Member member);
        public Member UpdateMember(int id, Member member);
        public void DeleteMember(int id);
    }
}
