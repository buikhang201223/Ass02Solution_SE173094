using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMembers();
        Member GetMemberByID(int MemberID);
        void InsertMember(Member member);
        void DeleteMember(int MemberID);
        void UpdateMember(Member member);
        List<Member> GetMemberByCityAndCountry(string text1, string text2);
    }
}
