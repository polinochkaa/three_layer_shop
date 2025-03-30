using SSU.ThreeLayer.BLL;
using SSU.ThreeLayer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.ThreeLayer.Common
{
    public static class DependencyResolver
    {
        static private IBaseProducts baseProducts;
        static private IProductLogic productLogic;

        static private IBaseSales baseSales;
        static private ISaleLogic promotionLogic;

        static public IBaseProducts BaseProducts
        {
            get => baseProducts ?? (baseProducts = new BaseProducts());
        }

        static public IProductLogic ProductLogic
        {
            get => productLogic ?? (productLogic = new ProductLogic(BaseProducts));
        }

        static public IBaseSales BaseSales
        {
            get => baseSales ?? (baseSales = new BaseSales());
        }

        static public ISaleLogic SaleLogic
        {
            get => promotionLogic ?? (promotionLogic = new SaleLogic(BaseSales));
        }
    }
}
