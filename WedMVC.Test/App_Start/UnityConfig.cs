using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using Unity;
using Unity.Injection;
using Unity.Lifetime;
using WebMVC.Data;
using WebMVC.Repository;
using WebMVC.Service;
using WedMVC.Test.Controllers;
using WedMVC.Test.Models;

namespace WedMVC.Test
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            //TODO: Register your type's mappings here.
            container.RegisterType<INhanVienRepository, NhanVienRepository>();
            container.RegisterType<INhanVienService, NhanVienService>();

            container.RegisterType<ISachRepository, SachRepository>();
            container.RegisterType<ISachService, SachService>();

            container.RegisterType<IChuDeRepository, ChuDeRepository>();
            container.RegisterType<IChuDeService, ChuDeService>();

            container.RegisterType<INhaXuatBanRepository, NhaXuatBanRepository>();
            container.RegisterType<INhaXuatBanService, NhaXuatBanService>();

            container.RegisterType<IMuonSachRepository, MuonSachRepository>();
            container.RegisterType<IMuonSachService, MuonSachService>();

            container.RegisterType<IDocGiaRepository, DocGiaRepository>();
            container.RegisterType<IDocGiaService, DocGiaService>();

            container.RegisterType<ITacGiaRepository, TacGiaRepository>();
            container.RegisterType<ITacGiaService, TacGiaService>();

            container.RegisterType<ITacGiaRepository, TacGiaRepository>();
            container.RegisterType<ITacGiaService, TacGiaService>();

            container.RegisterType<IHopDongRepository, HopDongRepository>();
            container.RegisterType<IHopDongService, HopDongService>();

            container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>();
            container.RegisterType<UserManager<ApplicationUser>>();
            container.RegisterType<DbContext, TestMVCDbContext>();
            container.RegisterType<ApplicationUserManager>();
            container.RegisterType<AccountController>(new InjectionConstructor());

        }
    }
}