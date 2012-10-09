using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public static class DataAccess
    {

        #region Help
        public static List<helps> GetAllHelp()
        {
            using (Entities context = new Entities())
            {
                return context.helps.Include("helpType").ToList();                
            }
        }
        #endregion

        #region HelpTypes
        public static event Action CategoriesChanged;

        public static List<helpType> GetAllCategories()
        {
            using (Entities context = new Entities())
            {
                return context.helpType.ToList();
            }
        }

        public static void RemoveCategory(helpType helptype)
        {
            using (Entities context = new Entities())
            {
                context.helpType.DeleteObject(context.helpType.FirstOrDefault(x => x.id_HelpType == helptype.id_HelpType));
                context.SaveChanges();
                CategoriesChanged();
            }
        }

        public static bool AddCategory(String categoryName) 
        {
            using (Entities context = new Entities())
            {
                if (context.helpType.FirstOrDefault(category => category.name_TypeHelp == categoryName) != null)
                    return false;
                context.helpType.AddObject(new helpType() { name_TypeHelp = categoryName });
                context.SaveChanges(System.Data.Objects.SaveOptions.AcceptAllChangesAfterSave);
                CategoriesChanged();
                return true;
            }
        }

        public static bool UpdateExistingCategory(helpType category, string newCategoryName) 
        {
            using (Entities context = new Entities())
            {
                if (context.helpType.FirstOrDefault(c=>c.name_TypeHelp==newCategoryName && c.id_HelpType!=category.id_HelpType) != null)
                    return false;
                helpType h=context.helpType.FirstOrDefault(x => x.id_HelpType == category.id_HelpType);
                if (h.name_TypeHelp != newCategoryName)
                {
                    h.name_TypeHelp = newCategoryName;
                    context.SaveChanges();
                    CategoriesChanged();
                }
                return true;
            }
        }
        #endregion
    }
}
