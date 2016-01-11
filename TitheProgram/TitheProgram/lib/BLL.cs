namespace TitheProgram.lib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using TitheProgram.Models;
    
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class BLL
    {
        private FileHandler fileHandler;
        private DataBaseLogicLayer dll;

        public BLL(FileHandler fileHandler, DataBaseLogicLayer dll)
        {
            this.fileHandler = fileHandler;
            this.dll = dll;
            this.Setup();
        }

        private void Setup()
        {
            if (this.fileHandler.DirectoryExists())
            {
                if (!this.fileHandler.HasDatabaseFile())
                {
                    this.fileHandler.CreateDatabaseFile();
                    this.dll.SetupDatabase();
                }
            }
            else
            {
                this.fileHandler.CreateDirectoryAndDatabaseFile();
            }
        }

        public string GetTotalMemberCount()
        {
            try
            {
                return this.dll.ReadTotalMembers();
            }
            catch (Exception ex)
            {
                return "0";
            }
        }

        public string GetTotalYearlyDonations()
        {
            try
            {
                return this.dll.ReadTotalDonationsForYear();
            }
            catch (Exception ex)
            {
                return "0";
            }
        }

        public bool AddMember(Member member)
        {
            try
            {
                return this.dll.CreateMember(member);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AddTitheRecord(TitheRecord tithe)
        {
            try
            {
                return this.dll.CreateTitheRecord(tithe);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Member> GetAllMembers()
        {
            try
            {
                return this.dll.ReadAllMembers();
            }
            catch (Exception ex)
            {
                return new List<Member>();
            }
        }

        public List<PaymentType> GetAllPaymentTypes()
        {
            try
            {
                return this.dll.ReadAllPaymentTypes();
            }
            catch (Exception ex)
            {
                return new List<PaymentType>();
            }
        }
    }
}
