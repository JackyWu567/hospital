using System.Configuration;
using System.Reflection;

namespace longhu.his.DALFactory
{
    public sealed class DataAccess
    {
        //private volatile static DataAccessor _instance = null;
        //private static readonly object lockObj = new object();

        //private DataAccessor() { }

        //public static DataAccessor Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //        {
        //            lock (lockObj)
        //            {
        //                _instance = new DataAccessor();
        //            }
        //        }

        //        return _instance;
        //    }
        //}
        // Look up the DAL implementation we should be using

        private static readonly string path = ConfigurationManager.AppSettings["FrmDAL"];

        private DataAccess() { }

        public static longhu.his.IDAL.IUser CreateUser()
        {
            string className = path + ".User";
            return (longhu.his.IDAL.IUser)Assembly.Load(path).CreateInstance(className);
        }

        public static longhu.his.IDAL.IDrugsManager CreateDrugsManager()
        {
            string className = path + ".DrugsManager";
            return (IDAL.IDrugsManager)Assembly.Load(path).CreateInstance(className);
        }
    }
}
