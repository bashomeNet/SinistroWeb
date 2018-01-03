using System.Data.Entity;

namespace Sinaf.DAL
{
    public  class DaoDb : IDaoDB
    {
        public DbContext getDb()
        {
            return null;
        }

        public void closeDb()
        {

        }
    }
}