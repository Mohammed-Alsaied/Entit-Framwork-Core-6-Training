namespace Datebase_Scaffolding
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Datebase Scaffolding Commands
            //scaffold-dbcontext 'Data Source=(localdb)\ProjectModels;Initial Catalog=EFCore Relationships' Microsoft.EntityFrameworkCore.SqlServer
            //scaffold-dbcontext 'Data Source=(localdb)\ProjectModels;Initial Catalog=EFCore Relationships' Microsoft.EntityFrameworkCore.SqlServer -Tables Blogs
            //scaffold-dbcontext 'Data Source=(localdb)\ProjectModels;Initial Catalog=EFCore Relationships' Microsoft.EntityFrameworkCore.SqlServer -Tables Blogs,
            //scaffold-dbcontext 'Data Source=(localdb)\ProjectModels;Initial Catalog=EFCore Relationships' Microsoft.EntityFrameworkCore.SqlServer OutputDir Entities
            //scaffold-dbcontext 'Data Source=(localdb)\ProjectModels;Initial Catalog=EFCore Relationships' Microsoft.EntityFrameworkCore.SqlServer -OutputDir Entities -ContextDir DbContext
            //scaffold-dbcontext 'Data Source=(localdb)\ProjectModels;Initial Catalog=EFCore Relationships' Microsoft.EntityFrameworkCore.SqlServer -ContextDir DbContext
            //scaffold-dbcontext 'Data Source=(localdb)\ProjectModels;Initial Catalog=EFCore Relationships' Microsoft.EntityFrameworkCore.SqlServer -OutputDir Entities -Context ApplicationDbContext        
            //scaffold-dbcontext 'Data Source=(localdb)\ProjectModels;Initial Catalog=EFCore Relationships' Microsoft.EntityFrameworkCore.SqlServer -OutputDir Entities -Context ApplicationDbContext -DataAnnotations
            #endregion
        }

    }
}
