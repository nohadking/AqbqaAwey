using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Domin.Entity;
using Infarstuructre.ViewModel;

namespace Infarstuructre.Data
{
    public class AqbqaAweyDbcotext : IdentityDbContext<ApplicationUser>
    {
        public AqbqaAweyDbcotext(DbContextOptions<AqbqaAweyDbcotext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.Entity<IdentityUser>().ToTable("Users");
            //builder.Entity<IdentityRole>().ToTable("Roles");
            //builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaim");
            //builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogin");
            //builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaim");
            //builder.Entity<IdentityUserToken<string>>().ToTable("RoleClaim");
            builder.Entity<TbAboutusAboutUsPage>().Property(x => x.IdAboutUsPage).HasDefaultValueSql("(newid())");
            builder.Entity<TbGuideTourguideinformation>().Property(x => x.IdTourguideinformation).HasDefaultValueSql("(newid())");
            builder.Entity<TbHomeBannerMain>().Property(x => x.IdBannerMain).HasDefaultValueSql("(newid())");
            builder.Entity<TbHomeBuckectListsDescription>().Property(x => x.IdBuckectLists).HasDefaultValueSql("(newid())");
            builder.Entity<TbHomeCategorieSbuckect>().Property(x => x.IdcategoriesBuckect).HasDefaultValueSql("(newid())");
            builder.Entity<TbHomeDtripsSchedule>().Property(x => x.IDtripsSchedule).HasDefaultValueSql("(newid())");
            builder.Entity<TbHomeFooterDatum>().Property(x => x.IdFooterData).HasDefaultValueSql("(newid())");
            builder.Entity<TbHomeFooterLatestNews>().Property(x => x.IdlatestNews).HasDefaultValueSql("(newid())");
            builder.Entity<TbHomeGetToKnowU>().Property(x => x.IdGetToKnowUs).HasDefaultValueSql("(newid())");
            builder.Entity<TbHomeOurPartner>().Property(x => x.IdOurPartners).HasDefaultValueSql("(newid())");
            builder.Entity<TbHomePhotoGalleryTrip>().Property(x => x.IdPhotoGalleryTrips).HasDefaultValueSql("(newid())");
            builder.Entity<TbHomeProvince>().Property(x => x.IdProvinces).HasDefaultValueSql("(newid())");
            builder.Entity<TbHomeTopDestination>().Property(x => x.IdTopDestinations).HasDefaultValueSql("(newid())");
            builder.Entity<TbHomeTourguidedescription>().Property(x => x.IdTourguidedescription).HasDefaultValueSql("(newid())");
           builder.Entity<TbHomeTripCategory>().Property(x => x.IdTripCategories).HasDefaultValueSql("(newid())");
           builder.Entity<TbHomeVedogallery>().Property(x => x.Idvedogallery).HasDefaultValueSql("(newid())");
            builder.Entity<TbSeRatingDatum>().Property(x => x.IdRatingData).HasDefaultValueSql("(newid())");

        }
        public DbSet<TbAboutusAboutUsPage> TbAboutusAboutUsPages { get; set; } 
        public DbSet<TbGuideTourguideinformation> TbGuideTourguideinformations { get; set; }
        public DbSet<TbHomeBannerMain> TbHomeBannerMains { get; set; } = null!;
        public DbSet<TbHomeBuckectListsDescription> TbHomeBuckectListsDescriptions { get; set; } 
        public DbSet<TbHomeCategorieSbuckect> TbHomeCategorieSbuckects { get; set; }
        public DbSet<TbHomeDtripsSchedule> TbHomeDtripsSchedules { get; set; } 
        public DbSet<TbHomeFooterDatum> TbHomeFooterData { get; set; } 
        public DbSet<TbHomeFooterLatestNews> TbHomeFooterLatestNews { get; set; } 
        public DbSet<TbHomeGetToKnowU> TbHomeGetToKnowUs { get; set; } 
        public DbSet<TbHomeOurPartner> TbHomeOurPartners { get; set; } 
        public DbSet<TbHomePhotoGalleryTrip> TbHomePhotoGalleryTrips { get; set; } 
        public DbSet<TbHomeProvince> TbHomeProvinces { get; set; } 
        public DbSet<TbHomeTopDestination> TbHomeTopDestinations { get; set; } 
        public DbSet<TbHomeTourguidedescription> TbHomeTourguidedescriptions { get; set; } 
        public DbSet<TbHomeTripCategory> TbHomeTripCategories { get; set; } 
        public DbSet<TbHomeVedogallery> TbHomeVedogalleries { get; set; } 
        public DbSet<TbSeRatingDatum> TbSeRatingData { get; set; }
    }
}
