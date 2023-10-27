using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class MemberDAO
    {
        //Using Singleton Pattern
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Member> GetMemberList()
        {
            var members = new List<Member>();
            try
            {
                using var context = new FstoreContext();
                members = context.Members.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return members;

        }

        public Member GetMemberByID(int MemberID)
        {
            Member mem = null;
            try
            {
                using var context = new FstoreContext();
                mem = context.Members.SingleOrDefault(c=>c.MemberId==MemberID);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return mem;
        }

        //-----------------------------------------------------------------
        //Add a new member
        public void AddNew(Member member)
        {
            try
            {
                Member mem = GetMemberByID(member.MemberId);
                if (mem == null)
                {
                    using var context = new FstoreContext();
                    context.Members.Add(member);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The member is already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        //-----------------------------------------------------------------
        //Add a new member
        public void Update(Member member)
        {
            try
            {
                Member mem = GetMemberByID(member.MemberId);
                if (mem != null)
                {
                    using var context = new FstoreContext();
                    context.Members.Update(member);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The member does not already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //-----------------------------------------------------------------
        //Add a new member
        public void Remove(int MemberId)
        {
            try
            {
                Member mem = GetMemberByID(MemberId);
                if (mem != null)
                {
                    using var context = new FstoreContext();
                    context.Members.Remove(mem);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The member does not already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<Member> GetMemberByCityAndCountry(string city, string country)
        {
            List<Member> FList = new List<Member>();
            var members = new List<Member>();
            try
            {
                using var context = new FstoreContext();
                members = context.Members.ToList();
                for (int i = 1; i <= members.Count; i++)
                {
                    if (members[i - 1].City == city && members[i - 1].Country == country) { FList.Add(members[i - 1]); }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
           
            return FList;
        }
    }
}
