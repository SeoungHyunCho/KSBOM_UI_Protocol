using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public partial class TestVectorSystem
    {
        #region Define
        #endregion

        #region Field
        private bool m_IsTestVectorFormUse;

        private string m_Group;
        private string m_Ver;
        private string m_Test;
        private string m_In;
        private string m_Ok;
        private string m_Mask;

        private List<string> m_GroupLists;
        private List<string> m_VerLists;

        private string m_Log = string.Empty;
        #endregion

        #region Constructor
        public TestVectorSystem()
        {
            this.IsTestVectorFormUse = true;

            this.Group = "device_group:\t";
            this.Ver = "device_ver:\t";
            this.Test = "test:\t";
            this.In = "in_end:\t";
            this.Ok = "ok_end:\t";
            this.Mask = "mask_end:\t";

            this.GroupLists = new List<string>();
            this.VerLists = new List<string>();

            this.Log = string.Empty;
        }
        #endregion

        #region Property
        public bool IsTestVectorFormUse
        {
            get { return this.m_IsTestVectorFormUse; }
            set { this.m_IsTestVectorFormUse = value; }
        }

        public string Group
        {
            get { return this.m_Group; }
            set { this.m_Group = value; }
        }
        public string Ver
        {
            get { return this.m_Ver; }
            set { this.m_Ver = value; }
        }
        public string Test
        {
            get { return this.m_Test; }
            set { this.m_Test = value; }
        }
        public string In
        {
            get { return this.m_In; }
            set { this.m_In = value; }
        }
        public string Ok
        {
            get { return this.m_Ok; }
            set { this.m_Ok = value; }
        }
        public string Mask
        {
            get { return this.m_Mask; }
            set { this.m_Mask = value; }
        }

        public List<string> GroupLists
        {
            get { return this.m_GroupLists; }
            set { this.m_GroupLists = value; }
        }
        public List<string> VerLists
        {
            get { return this.m_VerLists; }
            set { this.m_VerLists = value; }
        }


        public string Log
        {
            get { return this.m_Log; }
            set { this.m_Log = value; }
        }
        #endregion

        #region Event Handler
        #endregion

        #region Method
        public string SetTestVectorLine(string test)
        {
            return this.SetTestVectorLine(this.Ver, test);
        }
        public string SetTestVectorLine(string ver, string test)
        {
            return this.SetTestVectorLine(this.Group, ver, test);
        }
        public string SetTestVectorLine(string group, string ver, string test)
        {
            string ret = string.Empty;

            ret = group + ver + test;

            return ret;
        }
        #endregion

        #region Members
        #endregion
    }
}
