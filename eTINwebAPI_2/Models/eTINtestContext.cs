using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace eTINwebAPI_2.Models
{
    public partial class eTINtestContext : DbContext
    {
        public eTINtestContext()
        {
        }

        public eTINtestContext(DbContextOptions<eTINtestContext> options)
            : base(options)
        {
        }

        public string GetConnectionString()
        {
            return Startup.ConnectionString;
        }


       // public virtual DbSet<NbrTinInfo> NbrTinInfo { get; set; }
        public virtual DbSet<EcNidInfo> EcNidInfo { get; set; }
        public virtual DbSet<GenAddrType> GenAddrType { get; set; }
        public virtual DbSet<GenApplicationType> GenApplicationType { get; set; }
        public virtual DbSet<GenAttachType> GenAttachType { get; set; }
        public virtual DbSet<GenBloodGroup> GenBloodGroup { get; set; }
        public virtual DbSet<GenBusinessType> GenBusinessType { get; set; }
        public virtual DbSet<GenCircleInfo> GenCircleInfo { get; set; }
        public virtual DbSet<GenConfigType> GenConfigType { get; set; }
        public virtual DbSet<GenContactUpdateReason> GenContactUpdateReason { get; set; }
        public virtual DbSet<GenControllerAction> GenControllerAction { get; set; }
        public virtual DbSet<GenCountry> GenCountry { get; set; }
        public virtual DbSet<GenDataType> GenDataType { get; set; }
        public virtual DbSet<GenDesigList> GenDesigList { get; set; }
        public virtual DbSet<GenDistrict> GenDistrict { get; set; }
        public virtual DbSet<GenEditTypes> GenEditTypes { get; set; }
        public virtual DbSet<GenExtractTitles> GenExtractTitles { get; set; }
        public virtual DbSet<GenIpRestrict> GenIpRestrict { get; set; }
        public virtual DbSet<GenJurisdictionType> GenJurisdictionType { get; set; }
        public virtual DbSet<GenJuriSelections> GenJuriSelections { get; set; }
        public virtual DbSet<GenJuriSelectList> GenJuriSelectList { get; set; }
        public virtual DbSet<GenJuriSelectType> GenJuriSelectType { get; set; }
        public virtual DbSet<GenJuriSubList> GenJuriSubList { get; set; }
        public virtual DbSet<GenMenuList> GenMenuList { get; set; }
        public virtual DbSet<GenMenuUserType> GenMenuUserType { get; set; }
        public virtual DbSet<GenRangeInfo> GenRangeInfo { get; set; }
        public virtual DbSet<GenRegAddrType> GenRegAddrType { get; set; }
        public virtual DbSet<GenRegAttachType> GenRegAttachType { get; set; }
        public virtual DbSet<GenRegBusinessType> GenRegBusinessType { get; set; }
        public virtual DbSet<GenRegEditTypes> GenRegEditTypes { get; set; }
        public virtual DbSet<GenRegJuriType> GenRegJuriType { get; set; }
        public virtual DbSet<GenRegType> GenRegType { get; set; }
        public virtual DbSet<GenRegTypeMaster> GenRegTypeMaster { get; set; }
        public virtual DbSet<GenRegUploadType> GenRegUploadType { get; set; }
        public virtual DbSet<GenRegUserType> GenRegUserType { get; set; }
        public virtual DbSet<GenRelationship> GenRelationship { get; set; }
        public virtual DbSet<GenSecQuiz> GenSecQuiz { get; set; }
        public virtual DbSet<GenStatusReason> GenStatusReason { get; set; }
        public virtual DbSet<GenTaxArea> GenTaxArea { get; set; }
        public virtual DbSet<GenTaxCircle> GenTaxCircle { get; set; }
        public virtual DbSet<GenThana> GenThana { get; set; }
        public virtual DbSet<GenTokenInstruction> GenTokenInstruction { get; set; }
        public virtual DbSet<GenTokenRejectReason> GenTokenRejectReason { get; set; }
        public virtual DbSet<GenUpazilla> GenUpazilla { get; set; }
        public virtual DbSet<GenUploadType> GenUploadType { get; set; }
        public virtual DbSet<GenUsersPermissions> GenUsersPermissions { get; set; }
        public virtual DbSet<GenUserType> GenUserType { get; set; }
        public virtual DbSet<GenUserTypeMenus> GenUserTypeMenus { get; set; }
        public virtual DbSet<GenWorkPermitAuthorityList> GenWorkPermitAuthorityList { get; set; }
        public virtual DbSet<GenWsList> GenWsList { get; set; }
        public virtual DbSet<GenWsUserTypes> GenWsUserTypes { get; set; }
        public virtual DbSet<GenZoneInfo> GenZoneInfo { get; set; }
        public virtual DbSet<NbrAddrHistory> NbrAddrHistory { get; set; }
        public virtual DbSet<NbrAddrInfo> NbrAddrInfo { get; set; }
        public virtual DbSet<NbrAddrReq> NbrAddrReq { get; set; }
        public virtual DbSet<NbrAdtBusi> NbrAdtBusi { get; set; }
        public virtual DbSet<NbrAdtBusiHis> NbrAdtBusiHis { get; set; }
        public virtual DbSet<NbrContactHistory> NbrContactHistory { get; set; }
        public virtual DbSet<NbrEcHistory> NbrEcHistory { get; set; }
        public virtual DbSet<NbrFeedBack> NbrFeedBack { get; set; }
        public virtual DbSet<NbrInfoEditRequest> NbrInfoEditRequest { get; set; }
        public virtual DbSet<NbrInfoUpdate> NbrInfoUpdate { get; set; }
        public virtual DbSet<NbrInvalidActivate> NbrInvalidActivate { get; set; }
        public virtual DbSet<NbrInvalidLogins> NbrInvalidLogins { get; set; }
        public virtual DbSet<NbrJurisdictionTransfer> NbrJurisdictionTransfer { get; set; }
        public virtual DbSet<NbrMobileHis> NbrMobileHis { get; set; }
        public virtual DbSet<NbrMobileRequest> NbrMobileRequest { get; set; }
        public virtual DbSet<NbrNidDup> NbrNidDup { get; set; }
        public virtual DbSet<NbrPassRecovery> NbrPassRecovery { get; set; }
        public virtual DbSet<NbrRjscHis> NbrRjscHis { get; set; }
        public virtual DbSet<NbrRjscMasterHis> NbrRjscMasterHis { get; set; }
        public virtual DbSet<NbrSmsSend> NbrSmsSend { get; set; }
        public virtual DbSet<NbrTaxpayerUserVerify> NbrTaxpayerUserVerify { get; set; }
        public virtual DbSet<NbrTinAttachHis> NbrTinAttachHis { get; set; }
        public virtual DbSet<NbrTinAttachment> NbrTinAttachment { get; set; }
        public virtual DbSet<NbrTinBusiHis> NbrTinBusiHis { get; set; }
        public virtual DbSet<NbrTinBusinessInfo> NbrTinBusinessInfo { get; set; }
        public virtual DbSet<NbrTinBusiReq> NbrTinBusiReq { get; set; }
        public virtual DbSet<NbrTinInfo> NbrTinInfo { get; set; }
        public virtual DbSet<NbrTinInfoHis> NbrTinInfoHis { get; set; }
        public virtual DbSet<NbrTinStatusReq> NbrTinStatusReq { get; set; }
        public virtual DbSet<NbrTinUpload> NbrTinUpload { get; set; }
        public virtual DbSet<NbrTinVerify> NbrTinVerify { get; set; }
        public virtual DbSet<NbrTokenHistory> NbrTokenHistory { get; set; }
        public virtual DbSet<NbrUserAttachment> NbrUserAttachment { get; set; }
        public virtual DbSet<NbrUserAttachmentHis> NbrUserAttachmentHis { get; set; }
        public virtual DbSet<NbrUserHistory> NbrUserHistory { get; set; }
        public virtual DbSet<NbrUserLogonHis> NbrUserLogonHis { get; set; }
        public virtual DbSet<NbrUserPhotos> NbrUserPhotos { get; set; }
        public virtual DbSet<NbrUsers> NbrUsers { get; set; }
        public virtual DbSet<NbrUsersClaim> NbrUsersClaim { get; set; }
        public virtual DbSet<NbrUsersHis> NbrUsersHis { get; set; }
        public virtual DbSet<NbrVatHis> NbrVatHis { get; set; }
        public virtual DbSet<NbrVatInfo> NbrVatInfo { get; set; }
        public virtual DbSet<NbrVatReq> NbrVatReq { get; set; }
        public virtual DbSet<NbrWebApiUser> NbrWebApiUser { get; set; }
        public virtual DbSet<OldCircleLocation> OldCircleLocation { get; set; }
        public virtual DbSet<OldCurrentLocData> OldCurrentLocData { get; set; }
        public virtual DbSet<OldNbrTinData> OldNbrTinData { get; set; }
        public virtual DbSet<OldNbrVatData> OldNbrVatData { get; set; }
        public virtual DbSet<OldTinInfo> OldTinInfo { get; set; }
        public virtual DbSet<OldVatdata> OldVatdata { get; set; }
        public virtual DbSet<RjscBusinessInfo> RjscBusinessInfo { get; set; }
        public virtual DbSet<RjscIncorpInfo> RjscIncorpInfo { get; set; }
        public virtual DbSet<TrnTinLog> TrnTinLog { get; set; }
        public virtual DbSet<WsRequestDetail> WsRequestDetail { get; set; }
        public virtual DbSet<WsRequestMaster> WsRequestMaster { get; set; }
        public virtual DbSet<NbrWebApiTinValidationTracker> NbrWebApiTinValidationTracker { get; set; }
        public virtual DbSet<NbrWebApiAuthTracker> NbrWebApiAuthTracker { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                if (!optionsBuilder.IsConfigured)
                {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                    optionsBuilder.UseSqlServer(GetConnectionString());
                    //optionsBuilder.UseSqlServer("Server=172.16.16.114;Database=IFC_NBR_TIN;user id=sa;password=SqlServer2008;Connection Timeout=180;");
                    //optionsBuilder.UseSqlServer("Server=172.21.16.51;Database=NBR_LIVE_DB;user id=sa;password=S@lS!rv!r2008;Connection Timeout=180;");
                    //optionsBuilder.UseSqlServer("Server=172.21.16.51;Database=NBR_LIVE_DB;user id=sa;password=S@lS!rv!r2008;Connection Timeout=180;");
                }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EcNidInfo>(entity =>
            {
                entity.HasKey(e => e.NidInfoNo);

                entity.ToTable("EC_NID_INFO");

                entity.HasIndex(e => e.Nid)
                    .HasName("IX_EC_NID_INFO")
                    .IsUnique();

                entity.Property(e => e.NidInfoNo).HasColumnName("NID_INFO_NO");

                entity.Property(e => e.Nid)
                    .IsRequired()
                    .HasColumnName("NID")
                    .HasMaxLength(100);

                entity.Property(e => e.NidBfathName)
                    .HasColumnName("NID_BFATH_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NidBloodGroup)
                    .HasColumnName("NID_BLOOD_GROUP")
                    .HasMaxLength(50);

                entity.Property(e => e.NidBmothName)
                    .HasColumnName("NID_BMOTH_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NidBname)
                    .IsRequired()
                    .HasColumnName("NID_BNAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NidBperAddr)
                    .HasColumnName("NID_BPER_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.NidBpreAddr)
                    .HasColumnName("NID_BPRE_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.NidBspouseName)
                    .HasColumnName("NID_BSPOUSE_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NidDob)
                    .HasColumnName("NID_DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.NidGender)
                    .HasColumnName("NID_GENDER")
                    .HasMaxLength(50);

                entity.Property(e => e.NidName)
                    .IsRequired()
                    .HasColumnName("NID_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NidPhoto).HasColumnName("NID_PHOTO");

                entity.Property(e => e.SmartId)
                    .HasColumnName("SMART_ID")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<GenAddrType>(entity =>
            {
                entity.HasKey(e => e.AddrTypeNo);

                entity.ToTable("GEN_ADDR_TYPE");

                entity.HasIndex(e => e.AddrTypeNo)
                    .HasName("IX_ADDR_TYPE_NO_GET");

                entity.Property(e => e.AddrTypeNo)
                    .HasColumnName("ADDR_TYPE_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddrType)
                    .IsRequired()
                    .HasColumnName("ADDR_TYPE")
                    .HasMaxLength(100);

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<GenApplicationType>(entity =>
            {
                entity.HasKey(e => e.ApplTypeNo);

                entity.ToTable("GEN_APPLICATION_TYPE");

                entity.HasIndex(e => e.ApplicationType)
                    .HasName("IX_GEN_APPLICATION_TYPE")
                    .IsUnique();

                entity.Property(e => e.ApplTypeNo)
                    .HasColumnName("APPL_TYPE_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplicationType)
                    .IsRequired()
                    .HasColumnName("APPLICATION_TYPE")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<GenAttachType>(entity =>
            {
                entity.HasKey(e => e.AttachTypeNo);

                entity.ToTable("GEN_ATTACH_TYPE");

                entity.HasIndex(e => e.AttachType)
                    .HasName("IX_GEN_ATTACH_TYPE")
                    .IsUnique();

                entity.Property(e => e.AttachTypeNo)
                    .HasColumnName("ATTACH_TYPE_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttachExtList)
                    .IsRequired()
                    .HasColumnName("ATTACH_EXT_LIST")
                    .HasMaxLength(500);

                entity.Property(e => e.AttachType)
                    .IsRequired()
                    .HasColumnName("ATTACH_TYPE")
                    .HasMaxLength(100);

                entity.Property(e => e.MaxAttach)
                    .HasColumnName("MAX_ATTACH")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MaxSizeInMb)
                    .HasColumnName("MAX_SIZE_IN_MB")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GenBloodGroup>(entity =>
            {
                entity.HasKey(e => e.BloodGroupNo);

                entity.ToTable("GEN_BLOOD_GROUP");

                entity.HasIndex(e => e.BloodGroupName)
                    .HasName("IX_GEN_BLOOD_GROUP");

                entity.Property(e => e.BloodGroupNo).HasColumnName("BLOOD_GROUP_NO");

                entity.Property(e => e.BloodGroupName)
                    .IsRequired()
                    .HasColumnName("BLOOD_GROUP_NAME")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<GenBusinessType>(entity =>
            {
                entity.HasKey(e => e.BusiTypeNo);

                entity.ToTable("GEN_BUSINESS_TYPE");

                entity.HasIndex(e => e.BusinessType)
                    .HasName("IX_GEN_BUSINESS_TYPE")
                    .IsUnique();

                entity.Property(e => e.BusiTypeNo)
                    .HasColumnName("BUSI_TYPE_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.BusinessType)
                    .IsRequired()
                    .HasColumnName("BUSINESS_TYPE")
                    .HasMaxLength(100);

                entity.Property(e => e.Descr)
                    .HasColumnName("DESCR")
                    .HasMaxLength(500);

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<GenCircleInfo>(entity =>
            {
                entity.HasKey(e => e.CircleNo);

                entity.ToTable("GEN_CIRCLE_INFO");

                entity.HasIndex(e => e.CircleCode)
                    .HasName("IX_GEN_CIRCLE_INFO")
                    .IsUnique();

                entity.HasIndex(e => e.CircleNo)
                    .HasName("IX_GEN_CIRCLE_INFO_GET");

                entity.HasIndex(e => new { e.ZoneNo, e.CircleName })
                    .HasName("IX_GEN_CIRCLE_INFO_1")
                    .IsUnique();

                entity.Property(e => e.CircleNo).HasColumnName("CIRCLE_NO");

                entity.Property(e => e.Addr1)
                    .HasColumnName("ADDR1")
                    .HasMaxLength(500);

                entity.Property(e => e.Addr2)
                    .HasColumnName("ADDR2")
                    .HasMaxLength(500);

                entity.Property(e => e.AdmAddr)
                    .HasColumnName("ADM_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.AdmContact)
                    .HasColumnName("ADM_CONTACT")
                    .HasMaxLength(500);

                entity.Property(e => e.AdmName)
                    .HasColumnName("ADM_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.CircleCode)
                    .IsRequired()
                    .HasColumnName("CIRCLE_CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.CircleCodeBack)
                    .HasColumnName("CIRCLE_CODE_BACK")
                    .HasMaxLength(50);

                entity.Property(e => e.CircleName)
                    .IsRequired()
                    .HasColumnName("CIRCLE_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.CircleNameBack)
                    .HasColumnName("CIRCLE_NAME_BACK")
                    .HasMaxLength(100);

                entity.Property(e => e.CircleType)
                    .HasColumnName("CIRCLE_TYPE")
                    .HasMaxLength(500);

                entity.Property(e => e.Designation)
                    .HasColumnName("DESIGNATION")
                    .HasMaxLength(500);

                entity.Property(e => e.DistName)
                    .HasColumnName("DIST_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.EmailAddr)
                    .HasColumnName("EMAIL_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.Mobile)
                    .HasColumnName("MOBILE")
                    .HasMaxLength(500);

                entity.Property(e => e.OfficerName)
                    .HasColumnName("OFFICER_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.PayCodeComp)
                    .HasColumnName("PAY_CODE_COMP")
                    .HasMaxLength(500);

                entity.Property(e => e.PayCodeInd)
                    .HasColumnName("PAY_CODE_IND")
                    .HasMaxLength(500);

                entity.Property(e => e.PayCodeOth)
                    .HasColumnName("PAY_CODE_OTH")
                    .HasMaxLength(500);

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasMaxLength(500);

                entity.Property(e => e.RangeNo).HasColumnName("RANGE_NO");

                entity.Property(e => e.ZoneNo).HasColumnName("ZONE_NO");

                entity.HasOne(d => d.RangeNoNavigation)
                    .WithMany(p => p.GenCircleInfo)
                    .HasForeignKey(d => d.RangeNo)
                    .HasConstraintName("FK_GEN_CIRCLE_INFO_GEN_RANGE_INFO");

                entity.HasOne(d => d.ZoneNoNavigation)
                    .WithMany(p => p.GenCircleInfo)
                    .HasForeignKey(d => d.ZoneNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_CIRCLE_INFO_GEN_ZONE_INFO");
            });

            modelBuilder.Entity<GenConfigType>(entity =>
            {
                entity.HasKey(e => e.ConfigTypeNo);

                entity.ToTable("GEN_CONFIG_TYPE");

                entity.HasIndex(e => e.ConfigTypeName)
                    .HasName("IX_GEN_CONFIG_TYPE")
                    .IsUnique();

                entity.Property(e => e.ConfigTypeNo)
                    .HasColumnName("CONFIG_TYPE_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConfigTypeName)
                    .IsRequired()
                    .HasColumnName("CONFIG_TYPE_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.ConfigValues)
                    .HasColumnName("CONFIG_VALUES")
                    .HasMaxLength(50);

                entity.Property(e => e.DataTypeNo).HasColumnName("DATA_TYPE_NO");

                entity.Property(e => e.StrConfigVal)
                    .HasColumnName("STR_CONFIG_VAL")
                    .HasMaxLength(500);

                entity.HasOne(d => d.DataTypeNoNavigation)
                    .WithMany(p => p.GenConfigType)
                    .HasForeignKey(d => d.DataTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_CONFIG_TYPE_GEN_DATA_TYPE");
            });

            modelBuilder.Entity<GenContactUpdateReason>(entity =>
            {
                entity.HasKey(e => e.ContactUpdateReasonNo);

                entity.ToTable("GEN_CONTACT_UPDATE_REASON");

                entity.HasIndex(e => e.ContactUpdateReasonName)
                    .HasName("IX_GEN_CONTACT_UPDATE_REASON")
                    .IsUnique();

                entity.Property(e => e.ContactUpdateReasonNo).HasColumnName("CONTACT_UPDATE_REASON_NO");

                entity.Property(e => e.ContactUpdateReasonName)
                    .IsRequired()
                    .HasColumnName("CONTACT_UPDATE_REASON_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SlNo).HasColumnName("SL_NO");
            });

            modelBuilder.Entity<GenControllerAction>(entity =>
            {
                entity.HasKey(e => e.ActionNo);

                entity.ToTable("GEN_CONTROLLER_ACTION");

                entity.HasIndex(e => new { e.ControllerName, e.ActionName })
                    .HasName("IX_GEN_CONTROLLER_ACTION")
                    .IsUnique();

                entity.HasIndex(e => new { e.IsPublic, e.IsActive })
                    .HasName("IX_GEN_COUNTRY_GET");

                entity.Property(e => e.ActionNo).HasColumnName("ACTION_NO");

                entity.Property(e => e.ActionName)
                    .IsRequired()
                    .HasColumnName("ACTION_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.ControllerName)
                    .IsRequired()
                    .HasColumnName("CONTROLLER_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsAutoInclude)
                    .HasColumnName("IS_AUTO_INCLUDE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPublic)
                    .HasColumnName("IS_PUBLIC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentActionNo).HasColumnName("PARENT_ACTION_NO");

                entity.HasOne(d => d.ParentActionNoNavigation)
                    .WithMany(p => p.InverseParentActionNoNavigation)
                    .HasForeignKey(d => d.ParentActionNo)
                    .HasConstraintName("FK_GEN_CONTROLLER_ACTION_GEN_CONTROLLER_ACTION");
            });

            modelBuilder.Entity<GenCountry>(entity =>
            {
                entity.HasKey(e => e.CountNo);

                entity.ToTable("GEN_COUNTRY");

                entity.HasIndex(e => e.CountName)
                    .HasName("IX_GEN_COUNTRY")
                    .IsUnique();

                entity.HasIndex(e => e.IsLocal)
                    .HasName("IX_GEN_COUNTRY_GET");

                entity.Property(e => e.CountNo).HasColumnName("COUNT_NO");

                entity.Property(e => e.CountCode)
                    .HasColumnName("COUNT_CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.CountCodeNum)
                    .HasColumnName("COUNT_CODE_NUM")
                    .HasMaxLength(50);

                entity.Property(e => e.CountName)
                    .IsRequired()
                    .HasColumnName("COUNT_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.IsLocal)
                    .HasColumnName("IS_LOCAL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nationality)
                    .HasColumnName("NATIONALITY")
                    .HasMaxLength(100);

                entity.Property(e => e.OldCountCodeNum)
                    .HasColumnName("OLD_COUNT_CODE_NUM")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GenDataType>(entity =>
            {
                entity.HasKey(e => e.DataTypeNo);

                entity.ToTable("GEN_DATA_TYPE");

                entity.HasIndex(e => e.DataType)
                    .HasName("IX_GEN_DATA_TYPE")
                    .IsUnique();

                entity.Property(e => e.DataTypeNo)
                    .HasColumnName("DATA_TYPE_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasColumnName("DATA_TYPE")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<GenDesigList>(entity =>
            {
                entity.HasKey(e => e.DesigNo);

                entity.ToTable("GEN_DESIG_LIST");

                entity.HasIndex(e => new { e.DesigName, e.RegTypeNo })
                    .HasName("IX_GEN_DESIG_LIST")
                    .IsUnique();

                entity.HasIndex(e => new { e.RegTypeNo, e.IsActive })
                    .HasName("IX_GEN_DESIG_LIST_ACTIVE_DIST");

                entity.Property(e => e.DesigNo).HasColumnName("DESIG_NO");

                entity.Property(e => e.DesigName)
                    .IsRequired()
                    .HasColumnName("DESIG_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RegTypeNo).HasColumnName("REG_TYPE_NO");

                entity.Property(e => e.SlNo)
                    .HasColumnName("SL_NO")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.RegTypeNoNavigation)
                    .WithMany(p => p.GenDesigList)
                    .HasForeignKey(d => d.RegTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_DESIG_LIST_GEN_REG_TYPE");
            });

            modelBuilder.Entity<GenDistrict>(entity =>
            {
                entity.HasKey(e => e.DistNo);

                entity.ToTable("GEN_DISTRICT");

                entity.HasIndex(e => e.DistName)
                    .HasName("IX_GEN_DISTRICT")
                    .IsUnique();

                entity.Property(e => e.DistNo).HasColumnName("DIST_NO");

                entity.Property(e => e.CountNo).HasColumnName("COUNT_NO");

                entity.Property(e => e.DistName)
                    .IsRequired()
                    .HasColumnName("DIST_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.JuriParentDistNo).HasColumnName("JURI_PARENT_DIST_NO");

                entity.Property(e => e.PoCodeFrom)
                    .HasColumnName("PO_CODE_FROM")
                    .HasMaxLength(50);

                entity.Property(e => e.PoCodeTo)
                    .HasColumnName("PO_CODE_TO")
                    .HasMaxLength(50);

                entity.HasOne(d => d.CountNoNavigation)
                    .WithMany(p => p.GenDistrict)
                    .HasForeignKey(d => d.CountNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_DISTRICT_GEN_COUNTRY");
            });

            modelBuilder.Entity<GenEditTypes>(entity =>
            {
                entity.HasKey(e => e.EditTypeNo);

                entity.ToTable("GEN_EDIT_TYPES");

                entity.Property(e => e.EditTypeNo).HasColumnName("EDIT_TYPE_NO");

                entity.Property(e => e.ActionUrl)
                    .HasColumnName("ACTION_URL")
                    .HasMaxLength(500);

                entity.Property(e => e.EditTypes)
                    .IsRequired()
                    .HasColumnName("EDIT_TYPES")
                    .HasMaxLength(250);

                entity.Property(e => e.SlNo).HasColumnName("SL_NO");
            });

            modelBuilder.Entity<GenExtractTitles>(entity =>
            {
                entity.HasKey(e => e.ExtractNo);

                entity.ToTable("GEN_EXTRACT_TITLES");

                entity.HasIndex(e => e.ExtractTitle)
                    .HasName("IX_GEN_EXTRACT_TITLES")
                    .IsUnique();

                entity.Property(e => e.ExtractNo).HasColumnName("EXTRACT_NO");

                entity.Property(e => e.ExtractTitle)
                    .IsRequired()
                    .HasColumnName("EXTRACT_TITLE")
                    .HasMaxLength(100);

                entity.Property(e => e.Slno)
                    .HasColumnName("SLNO")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GenIpRestrict>(entity =>
            {
                entity.HasKey(e => e.IpRestrictNo);

                entity.ToTable("GEN_IP_RESTRICT");

                entity.HasIndex(e => e.IpAddr)
                    .HasName("IX_GEN_IP_RESTRICT")
                    .IsUnique();

                entity.Property(e => e.IpRestrictNo).HasColumnName("IP_RESTRICT_NO");

                entity.Property(e => e.InsertTime)
                    .HasColumnName("INSERT_TIME")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IpAddr)
                    .IsRequired()
                    .HasColumnName("IP_ADDR")
                    .HasMaxLength(200);

                entity.Property(e => e.IsBlocked)
                    .IsRequired()
                    .HasColumnName("IS_BLOCKED")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<GenJurisdictionType>(entity =>
            {
                entity.HasKey(e => e.JuriTypeNo);

                entity.ToTable("GEN_JURISDICTION_TYPE");

                entity.HasIndex(e => e.JuriTypeName)
                    .HasName("IX_GEN_JURISDICTION_TYPE")
                    .IsUnique();

                entity.Property(e => e.JuriTypeNo).HasColumnName("JURI_TYPE_NO");

                entity.Property(e => e.Bdescr)
                    .HasColumnName("BDESCR")
                    .HasMaxLength(2000);

                entity.Property(e => e.Descr)
                    .HasColumnName("DESCR")
                    .HasMaxLength(2000);

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JuriTypeName)
                    .IsRequired()
                    .HasColumnName("JURI_TYPE_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.SlNo).HasColumnName("SL_NO");
            });

            modelBuilder.Entity<GenJuriSelections>(entity =>
            {
                entity.HasKey(e => e.JuriSelectNo);

                entity.ToTable("GEN_JURI_SELECTIONS");

                entity.HasIndex(e => new { e.JuriSelectTypeNo, e.JuriTypeNo })
                    .HasName("IX_GEN_JURI_SELECTIONS")
                    .IsUnique();

                entity.Property(e => e.JuriSelectNo).HasColumnName("JURI_SELECT_NO");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("IS_ACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JuriSelectTypeNo).HasColumnName("JURI_SELECT_TYPE_NO");

                entity.Property(e => e.JuriTypeNo).HasColumnName("JURI_TYPE_NO");

                entity.HasOne(d => d.JuriSelectTypeNoNavigation)
                    .WithMany(p => p.GenJuriSelections)
                    .HasForeignKey(d => d.JuriSelectTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_JURI_SELECTIONS_GEN_JURI_SELECT_TYPE");

                entity.HasOne(d => d.JuriTypeNoNavigation)
                    .WithMany(p => p.GenJuriSelections)
                    .HasForeignKey(d => d.JuriTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_JURI_SELECTIONS_GEN_JURISDICTION_TYPE");
            });

            modelBuilder.Entity<GenJuriSelectList>(entity =>
            {
                entity.HasKey(e => e.JuriSelectListNo);

                entity.ToTable("GEN_JURI_SELECT_LIST");

                entity.HasIndex(e => e.JuriSelectListNo)
                    .HasName("IX_JURI_SELECT_LIST_NO_GET");

                entity.Property(e => e.JuriSelectListNo).HasColumnName("JURI_SELECT_LIST_NO");

                entity.Property(e => e.Bdescr)
                    .HasColumnName("BDESCR")
                    .HasMaxLength(2000);

                entity.Property(e => e.CircleNo).HasColumnName("CIRCLE_NO");

                entity.Property(e => e.Descr)
                    .HasColumnName("DESCR")
                    .HasMaxLength(2000);

                entity.Property(e => e.DistNo).HasColumnName("DIST_NO");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("IS_ACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsAssesseeName)
                    .HasColumnName("IS_ASSESSEE_NAME")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsInputRequired)
                    .HasColumnName("IS_INPUT_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsLocation)
                    .HasColumnName("IS_LOCATION")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSubExists).HasColumnName("IS_SUB_EXISTS");

                entity.Property(e => e.IsWard).HasColumnName("IS_WARD");

                entity.Property(e => e.JuriSelectTypeNo).HasColumnName("JURI_SELECT_TYPE_NO");

                entity.Property(e => e.JuriTypeNo).HasColumnName("JURI_TYPE_NO");

                entity.Property(e => e.ListName)
                    .IsRequired()
                    .HasColumnName("LIST_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.LocalForeignType)
                    .HasColumnName("LOCAL_FOREIGN_TYPE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PoCodeFrom)
                    .HasColumnName("PO_CODE_FROM")
                    .HasMaxLength(50);

                entity.Property(e => e.PoCodeTo)
                    .HasColumnName("PO_CODE_TO")
                    .HasMaxLength(50);

                entity.Property(e => e.SlNo)
                    .HasColumnName("SL_NO")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CircleNoNavigation)
                    .WithMany(p => p.GenJuriSelectList)
                    .HasForeignKey(d => d.CircleNo)
                    .HasConstraintName("FK_GEN_JURI_SELECT_LIST_GEN_CIRCLE_INFO");

                entity.HasOne(d => d.DistNoNavigation)
                    .WithMany(p => p.GenJuriSelectList)
                    .HasForeignKey(d => d.DistNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_JURI_SELECT_LIST_GEN_DISTRICT");

                entity.HasOne(d => d.JuriSelectTypeNoNavigation)
                    .WithMany(p => p.GenJuriSelectList)
                    .HasForeignKey(d => d.JuriSelectTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_JURI_SELECT_LIST_GEN_JURI_SELECT_TYPE");

                entity.HasOne(d => d.JuriTypeNoNavigation)
                    .WithMany(p => p.GenJuriSelectList)
                    .HasForeignKey(d => d.JuriTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_JURI_SELECT_LIST_GEN_JURISDICTION_TYPE");
            });

            modelBuilder.Entity<GenJuriSelectType>(entity =>
            {
                entity.HasKey(e => e.JuriSelectTypeNo);

                entity.ToTable("GEN_JURI_SELECT_TYPE");

                entity.HasIndex(e => e.SelectTypeName)
                    .HasName("IX_GEN_JURI_SELECT_TYPE")
                    .IsUnique();

                entity.Property(e => e.JuriSelectTypeNo).HasColumnName("JURI_SELECT_TYPE_NO");

                entity.Property(e => e.SelectTypeName)
                    .IsRequired()
                    .HasColumnName("SELECT_TYPE_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.SlNo).HasColumnName("SL_NO");
            });

            modelBuilder.Entity<GenJuriSubList>(entity =>
            {
                entity.HasKey(e => e.JuriSubListNo);

                entity.ToTable("GEN_JURI_SUB_LIST");

                entity.HasIndex(e => new { e.JuriSelectListNo, e.SubListName })
                    .HasName("IX_GEN_JURI_SUB_LIST")
                    .IsUnique();

                entity.HasIndex(e => new { e.JuriSelectListNo, e.IsActive, e.IsLetterMatch })
                    .HasName("IX_GEN_JURI_SUB_LIST_GET");

                entity.Property(e => e.JuriSubListNo).HasColumnName("JURI_SUB_LIST_NO");

                entity.Property(e => e.Bdescr)
                    .HasColumnName("BDESCR")
                    .HasMaxLength(2000);

                entity.Property(e => e.CircleNo).HasColumnName("CIRCLE_NO");

                entity.Property(e => e.Descr)
                    .HasColumnName("DESCR")
                    .HasMaxLength(2000);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("IS_ACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsInputRequired)
                    .HasColumnName("IS_INPUT_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsLetterMatch)
                    .HasColumnName("IS_LETTER_MATCH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsLocation)
                    .HasColumnName("IS_LOCATION")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JuriSelectListNo).HasColumnName("JURI_SELECT_LIST_NO");

                entity.Property(e => e.PoCodeFrom)
                    .HasColumnName("PO_CODE_FROM")
                    .HasMaxLength(50);

                entity.Property(e => e.PoCodeTo)
                    .HasColumnName("PO_CODE_TO")
                    .HasMaxLength(50);

                entity.Property(e => e.SlNo)
                    .HasColumnName("SL_NO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SubListName)
                    .IsRequired()
                    .HasColumnName("SUB_LIST_NAME")
                    .HasMaxLength(200);

                entity.HasOne(d => d.CircleNoNavigation)
                    .WithMany(p => p.GenJuriSubList)
                    .HasForeignKey(d => d.CircleNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_JURI_SUB_LIST_GEN_CIRCLE_INFO");

                entity.HasOne(d => d.JuriSelectListNoNavigation)
                    .WithMany(p => p.GenJuriSubList)
                    .HasForeignKey(d => d.JuriSelectListNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_JURI_SUB_LIST_GEN_JURI_SELECT_LIST");
            });

            modelBuilder.Entity<GenMenuList>(entity =>
            {
                entity.HasKey(e => e.MenuNo);

                entity.ToTable("GEN_MENU_LIST");

                entity.HasIndex(e => e.MenuName)
                    .HasName("IX_GEN_MENU_LIST")
                    .IsUnique();

                entity.Property(e => e.MenuNo).HasColumnName("MENU_NO");

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuActionName)
                    .HasColumnName("MENU_ACTION_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.MenuControllerName)
                    .HasColumnName("MENU_CONTROLLER_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.MenuName)
                    .IsRequired()
                    .HasColumnName("MENU_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.MenuTips)
                    .HasColumnName("MENU_TIPS")
                    .HasMaxLength(500);

                entity.Property(e => e.MenuUrl)
                    .IsRequired()
                    .HasColumnName("MENU_URL")
                    .HasMaxLength(200);

                entity.Property(e => e.SlNo)
                    .HasColumnName("SL_NO")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GenMenuUserType>(entity =>
            {
                entity.HasKey(e => e.MenuUserTypeNo);

                entity.ToTable("GEN_MENU_USER_TYPE");

                entity.HasIndex(e => new { e.MenuNo, e.UserTypeNo })
                    .HasName("IX_GEN_MENU_USER_TYPE")
                    .IsUnique();

                entity.HasIndex(e => new { e.IsActive, e.MenuNo, e.UserTypeNo })
                    .HasName("IX_GEN_MENU_USER_TYPE_GET");

                entity.Property(e => e.MenuUserTypeNo).HasColumnName("MENU_USER_TYPE_NO");

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuNo).HasColumnName("MENU_NO");

                entity.Property(e => e.SlNo)
                    .HasColumnName("SL_NO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserTypeNo).HasColumnName("USER_TYPE_NO");

                entity.HasOne(d => d.MenuNoNavigation)
                    .WithMany(p => p.GenMenuUserType)
                    .HasForeignKey(d => d.MenuNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_MENU_USER_TYPE_GEN_MENU_LIST");

                entity.HasOne(d => d.UserTypeNoNavigation)
                    .WithMany(p => p.GenMenuUserType)
                    .HasForeignKey(d => d.UserTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_MENU_USER_TYPE_GEN_USER_TYPE");
            });

            modelBuilder.Entity<GenRangeInfo>(entity =>
            {
                entity.HasKey(e => e.RangeNo);

                entity.ToTable("GEN_RANGE_INFO");

                entity.HasIndex(e => new { e.ZoneNo, e.RangeName })
                    .HasName("IX_GEN_RANGE_INFO")
                    .IsUnique();

                entity.Property(e => e.RangeNo).HasColumnName("RANGE_NO");

                entity.Property(e => e.AdmAddr)
                    .HasColumnName("ADM_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.AdmContact)
                    .HasColumnName("ADM_CONTACT")
                    .HasMaxLength(500);

                entity.Property(e => e.AdmName)
                    .HasColumnName("ADM_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.RangeName)
                    .IsRequired()
                    .HasColumnName("RANGE_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.ZoneNo).HasColumnName("ZONE_NO");

                entity.HasOne(d => d.ZoneNoNavigation)
                    .WithMany(p => p.GenRangeInfo)
                    .HasForeignKey(d => d.ZoneNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_RANGE_INFO_GEN_ZONE_INFO");
            });

            modelBuilder.Entity<GenRegAddrType>(entity =>
            {
                entity.HasKey(e => e.RegAddrTypeNo);

                entity.ToTable("GEN_REG_ADDR_TYPE");

                entity.HasIndex(e => new { e.RegTypeNo, e.AddrTypeNo })
                    .HasName("IX_GEN_REG_ADDR_TYPE")
                    .IsUnique();

                entity.Property(e => e.RegAddrTypeNo).HasColumnName("REG_ADDR_TYPE_NO");

                entity.Property(e => e.AddrTypeNo).HasColumnName("ADDR_TYPE_NO");

                entity.Property(e => e.IsRequired)
                    .IsRequired()
                    .HasColumnName("IS_REQUIRED")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RegTypeNo).HasColumnName("REG_TYPE_NO");

                entity.HasOne(d => d.AddrTypeNoNavigation)
                    .WithMany(p => p.GenRegAddrType)
                    .HasForeignKey(d => d.AddrTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_REG_ADDR_TYPE_GEN_ADDR_TYPE");

                entity.HasOne(d => d.RegTypeNoNavigation)
                    .WithMany(p => p.GenRegAddrType)
                    .HasForeignKey(d => d.RegTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_REG_ADDR_TYPE_GEN_REG_TYPE");
            });

            modelBuilder.Entity<GenRegAttachType>(entity =>
            {
                entity.HasKey(e => e.RegAttachNo);

                entity.ToTable("GEN_REG_ATTACH_TYPE");

                entity.HasIndex(e => new { e.RegTypeNo, e.AttachTypeNo })
                    .HasName("IX_GEN_REG_ATTACH_TYPE")
                    .IsUnique();

                entity.Property(e => e.RegAttachNo).HasColumnName("REG_ATTACH_NO");

                entity.Property(e => e.AttachTypeNo).HasColumnName("ATTACH_TYPE_NO");

                entity.Property(e => e.IsAllowed)
                    .HasColumnName("IS_ALLOWED")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsRequired)
                    .HasColumnName("IS_REQUIRED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RegTypeNo).HasColumnName("REG_TYPE_NO");

                entity.HasOne(d => d.AttachTypeNoNavigation)
                    .WithMany(p => p.GenRegAttachType)
                    .HasForeignKey(d => d.AttachTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_REG_ATTACH_TYPE_GEN_ATTACH_TYPE");

                entity.HasOne(d => d.RegTypeNoNavigation)
                    .WithMany(p => p.GenRegAttachType)
                    .HasForeignKey(d => d.RegTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_REG_ATTACH_TYPE_GEN_REG_TYPE");
            });

            modelBuilder.Entity<GenRegBusinessType>(entity =>
            {
                entity.HasKey(e => e.RegBusiTypeNo);

                entity.ToTable("GEN_REG_BUSINESS_TYPE");

                entity.HasIndex(e => new { e.RegTypeNo, e.BusiTypeNo })
                    .HasName("IX_GEN_REG_BUSINESS_TYPE_GET")
                    .HasFilter("([IS_ALLOWED]=(1))");

                entity.Property(e => e.RegBusiTypeNo).HasColumnName("REG_BUSI_TYPE_NO");

                entity.Property(e => e.BusiTypeNo).HasColumnName("BUSI_TYPE_NO");

                entity.Property(e => e.IsAllowed).HasColumnName("IS_ALLOWED");

                entity.Property(e => e.MaxEntry).HasColumnName("MAX_ENTRY");

                entity.Property(e => e.MinEntry).HasColumnName("MIN_ENTRY");

                entity.Property(e => e.RegTypeNo).HasColumnName("REG_TYPE_NO");

                entity.HasOne(d => d.BusiTypeNoNavigation)
                    .WithMany(p => p.GenRegBusinessType)
                    .HasForeignKey(d => d.BusiTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_REG_BUSINESS_TYPE_GEN_BUSINESS_TYPE");

                entity.HasOne(d => d.RegTypeNoNavigation)
                    .WithMany(p => p.GenRegBusinessType)
                    .HasForeignKey(d => d.RegTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_REG_BUSINESS_TYPE_GEN_REG_TYPE");
            });

            modelBuilder.Entity<GenRegEditTypes>(entity =>
            {
                entity.HasKey(e => e.RegEditTypeNo);

                entity.ToTable("GEN_REG_EDIT_TYPES");

                entity.Property(e => e.RegEditTypeNo).HasColumnName("REG_EDIT_TYPE_NO");

                entity.Property(e => e.EditTypeNo).HasColumnName("EDIT_TYPE_NO");

                entity.Property(e => e.IsAllowed).HasColumnName("IS_ALLOWED");

                entity.Property(e => e.RegTypeNo).HasColumnName("REG_TYPE_NO");

                entity.HasOne(d => d.EditTypeNoNavigation)
                    .WithMany(p => p.GenRegEditTypes)
                    .HasForeignKey(d => d.EditTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_REG_EDIT_TYPES_GEN_EDIT_TYPES");

                entity.HasOne(d => d.RegTypeNoNavigation)
                    .WithMany(p => p.GenRegEditTypes)
                    .HasForeignKey(d => d.RegTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_REG_EDIT_TYPES_GEN_REG_TYPE");
            });

            modelBuilder.Entity<GenRegJuriType>(entity =>
            {
                entity.HasKey(e => e.RegJuriTypeNo);

                entity.ToTable("GEN_REG_JURI_TYPE");

                entity.HasIndex(e => new { e.RegTypeNo, e.JuriTypeNo })
                    .HasName("IX_GEN_REG_JURI_TYPE")
                    .IsUnique();

                entity.Property(e => e.RegJuriTypeNo).HasColumnName("REG_JURI_TYPE_NO");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("IS_ACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JuriTypeNo).HasColumnName("JURI_TYPE_NO");

                entity.Property(e => e.RegTypeNo).HasColumnName("REG_TYPE_NO");

                entity.HasOne(d => d.JuriTypeNoNavigation)
                    .WithMany(p => p.GenRegJuriType)
                    .HasForeignKey(d => d.JuriTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_REG_JURI_TYPE_GEN_JURISDICTION_TYPE");

                entity.HasOne(d => d.RegTypeNoNavigation)
                    .WithMany(p => p.GenRegJuriType)
                    .HasForeignKey(d => d.RegTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_REG_JURI_TYPE_GEN_REG_TYPE");
            });

            modelBuilder.Entity<GenRegType>(entity =>
            {
                entity.HasKey(e => e.RegTypeNo);

                entity.ToTable("GEN_REG_TYPE");

                entity.HasIndex(e => e.RegTypeName)
                    .HasName("IX_GEN_REG_TYPE")
                    .IsUnique();

                entity.Property(e => e.RegTypeNo)
                    .HasColumnName("REG_TYPE_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.CertName)
                    .HasColumnName("CERT_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("IS_ACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsForForeign)
                    .HasColumnName("IS_FOR_FOREIGN")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsForLocal)
                    .HasColumnName("IS_FOR_LOCAL")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsTokenForNew)
                    .HasColumnName("IS_TOKEN_FOR_NEW")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsTokenForOld)
                    .HasColumnName("IS_TOKEN_FOR_OLD")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RegTypeMastNo).HasColumnName("REG_TYPE_MAST_NO");

                entity.Property(e => e.RegTypeName)
                    .IsRequired()
                    .HasColumnName("REG_TYPE_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.RegTypeNum)
                    .HasColumnName("REG_TYPE_NUM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SlNo)
                    .HasColumnName("SL_NO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ToolTips)
                    .HasColumnName("TOOL_TIPS")
                    .HasMaxLength(2000);

                entity.HasOne(d => d.RegTypeMastNoNavigation)
                    .WithMany(p => p.GenRegType)
                    .HasForeignKey(d => d.RegTypeMastNo)
                    .HasConstraintName("FK_GEN_REG_TYPE_GEN_REG_TYPE_MASTER");
            });

            modelBuilder.Entity<GenRegTypeMaster>(entity =>
            {
                entity.HasKey(e => e.RegTypeMastNo);

                entity.ToTable("GEN_REG_TYPE_MASTER");

                entity.HasIndex(e => e.RegTypeMastName)
                    .HasName("IX_GEN_REG_TYPE_MASTER")
                    .IsUnique();

                entity.Property(e => e.RegTypeMastNo).HasColumnName("REG_TYPE_MAST_NO");

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RegTypeMastName)
                    .IsRequired()
                    .HasColumnName("REG_TYPE_MAST_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.SlNo)
                    .HasColumnName("SL_NO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ToolTips)
                    .HasColumnName("TOOL_TIPS")
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<GenRegUploadType>(entity =>
            {
                entity.HasKey(e => e.RegUploadNo);

                entity.ToTable("GEN_REG_UPLOAD_TYPE");

                entity.Property(e => e.RegUploadNo).HasColumnName("REG_UPLOAD_NO");

                entity.Property(e => e.IsAllowed)
                    .HasColumnName("IS_ALLOWED")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RegTypeNo).HasColumnName("REG_TYPE_NO");

                entity.Property(e => e.UploadTypeNo).HasColumnName("UPLOAD_TYPE_NO");

                entity.HasOne(d => d.RegTypeNoNavigation)
                    .WithMany(p => p.GenRegUploadType)
                    .HasForeignKey(d => d.RegTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_REG_UPLOAD_TYPE_GEN_REG_TYPE");

                entity.HasOne(d => d.UploadTypeNoNavigation)
                    .WithMany(p => p.GenRegUploadType)
                    .HasForeignKey(d => d.UploadTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_REG_UPLOAD_TYPE_GEN_UPLOAD_TYPE");
            });

            modelBuilder.Entity<GenRegUserType>(entity =>
            {
                entity.HasKey(e => e.RegUserTypeNo);

                entity.ToTable("GEN_REG_USER_TYPE");

                entity.HasIndex(e => new { e.UserTypeNo, e.RegTypeNo, e.IsOld })
                    .HasName("IX_GEN_REG_USER_TYPE")
                    .IsUnique();

                entity.Property(e => e.RegUserTypeNo).HasColumnName("REG_USER_TYPE_NO");

                entity.Property(e => e.IsAllowed)
                    .IsRequired()
                    .HasColumnName("IS_ALLOWED")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsNewTin)
                    .HasColumnName("IS_NEW_TIN")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsOld).HasColumnName("IS_OLD");

                entity.Property(e => e.RegTypeNo).HasColumnName("REG_TYPE_NO");

                entity.Property(e => e.UserTypeNo).HasColumnName("USER_TYPE_NO");

                entity.HasOne(d => d.RegTypeNoNavigation)
                    .WithMany(p => p.GenRegUserType)
                    .HasForeignKey(d => d.RegTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_REG_USER_TYPE_GEN_REG_TYPE");

                entity.HasOne(d => d.UserTypeNoNavigation)
                    .WithMany(p => p.GenRegUserType)
                    .HasForeignKey(d => d.UserTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_REG_USER_TYPE_GEN_USER_TYPE");
            });

            modelBuilder.Entity<GenRelationship>(entity =>
            {
                entity.HasKey(e => e.RelNo);

                entity.ToTable("GEN_RELATIONSHIP");

                entity.HasIndex(e => e.RelName)
                    .HasName("IX_GEN_RELATIONSHIP")
                    .IsUnique();

                entity.Property(e => e.RelNo).HasColumnName("REL_NO");

                entity.Property(e => e.RelName)
                    .IsRequired()
                    .HasColumnName("REL_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.SlNo)
                    .HasColumnName("SL_NO")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GenSecQuiz>(entity =>
            {
                entity.HasKey(e => e.SecQuizNo);

                entity.ToTable("GEN_SEC_QUIZ");

                entity.Property(e => e.SecQuizNo).HasColumnName("SEC_QUIZ_NO");

                entity.Property(e => e.SecQuiz)
                    .IsRequired()
                    .HasColumnName("SEC_QUIZ")
                    .HasMaxLength(500);

                entity.Property(e => e.SlNo)
                    .HasColumnName("SL_NO")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GenStatusReason>(entity =>
            {
                entity.HasKey(e => e.StatusReasonNo);

                entity.ToTable("GEN_STATUS_REASON");

                entity.Property(e => e.StatusReasonNo).HasColumnName("STATUS_REASON_NO");

                entity.Property(e => e.StatusReason)
                    .IsRequired()
                    .HasColumnName("STATUS_REASON")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<GenTaxArea>(entity =>
            {
                entity.HasKey(e => e.AreaNo);

                entity.ToTable("GEN_TAX_AREA");

                entity.Property(e => e.AreaNo).HasColumnName("AREA_NO");

                entity.Property(e => e.AreaAddr)
                    .HasColumnName("AREA_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.AreaInfo)
                    .HasColumnName("AREA_INFO")
                    .HasMaxLength(500);

                entity.Property(e => e.AreaName)
                    .IsRequired()
                    .HasColumnName("AREA_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.DistNo).HasColumnName("DIST_NO");

                entity.Property(e => e.OldDbZoneName)
                    .HasColumnName("OLD_DB_ZONE_NAME")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<GenTaxCircle>(entity =>
            {
                entity.HasKey(e => e.CircleNo);

                entity.ToTable("GEN_TAX_CIRCLE");

                entity.HasIndex(e => new { e.AreaNo, e.CircleName })
                    .HasName("IX_GEN_TAX_CIRCLE")
                    .IsUnique();

                entity.Property(e => e.CircleNo).HasColumnName("CIRCLE_NO");

                entity.Property(e => e.AreaNo).HasColumnName("AREA_NO");

                entity.Property(e => e.CircleAddr)
                    .HasColumnName("CIRCLE_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.CircleInfo)
                    .HasColumnName("CIRCLE_INFO")
                    .HasMaxLength(500);

                entity.Property(e => e.CircleName)
                    .IsRequired()
                    .HasColumnName("CIRCLE_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.OldDbCircleName)
                    .HasColumnName("OLD_DB_CIRCLE_NAME")
                    .HasMaxLength(500);

                entity.HasOne(d => d.AreaNoNavigation)
                    .WithMany(p => p.GenTaxCircle)
                    .HasForeignKey(d => d.AreaNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_TAX_CIRCLE_GEN_TAX_AREA");
            });

            modelBuilder.Entity<GenThana>(entity =>
            {
                entity.HasKey(e => e.ThanaNo);

                entity.ToTable("GEN_THANA");

                entity.HasIndex(e => e.DistNo)
                    .HasName("IX_GEN_THANA_BY_DIST");

                entity.HasIndex(e => new { e.DistNo, e.ThanaName })
                    .HasName("IX_GEN_THANA")
                    .IsUnique();

                entity.Property(e => e.ThanaNo).HasColumnName("THANA_NO");

                entity.Property(e => e.DistNo).HasColumnName("DIST_NO");

                entity.Property(e => e.PoCodeFrom)
                    .HasColumnName("PO_CODE_FROM")
                    .HasMaxLength(50);

                entity.Property(e => e.PoCodeTo)
                    .HasColumnName("PO_CODE_TO")
                    .HasMaxLength(50);

                entity.Property(e => e.ThanaName)
                    .IsRequired()
                    .HasColumnName("THANA_NAME")
                    .HasMaxLength(100);

                entity.HasOne(d => d.DistNoNavigation)
                    .WithMany(p => p.GenThana)
                    .HasForeignKey(d => d.DistNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_THANA_GEN_DISTRICT");
            });

            modelBuilder.Entity<GenTokenInstruction>(entity =>
            {
                entity.HasKey(e => e.TokenInstructNo);

                entity.ToTable("GEN_TOKEN_INSTRUCTION");

                entity.HasIndex(e => new { e.RegTypeNo, e.Instruction })
                    .HasName("IX_GEN_TOKEN_INSTRUCTION")
                    .IsUnique();

                entity.Property(e => e.TokenInstructNo).HasColumnName("TOKEN_INSTRUCT_NO");

                entity.Property(e => e.InstructDetail)
                    .HasColumnName("INSTRUCT_DETAIL")
                    .HasMaxLength(1000);

                entity.Property(e => e.Instruction)
                    .IsRequired()
                    .HasColumnName("INSTRUCTION")
                    .HasMaxLength(250);

                entity.Property(e => e.RegTypeNo).HasColumnName("REG_TYPE_NO");

                entity.Property(e => e.SlNo).HasColumnName("SL_NO");

                entity.HasOne(d => d.RegTypeNoNavigation)
                    .WithMany(p => p.GenTokenInstruction)
                    .HasForeignKey(d => d.RegTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_TOKEN_INSTRUCTION_GEN_REG_TYPE");
            });

            modelBuilder.Entity<GenTokenRejectReason>(entity =>
            {
                entity.HasKey(e => e.TokenRejectReasonNo);

                entity.ToTable("GEN_TOKEN_REJECT_REASON");

                entity.HasIndex(e => new { e.RejectReason, e.RegTypeNo })
                    .HasName("IX_GEN_TOKEN_REJECT_REASON")
                    .IsUnique();

                entity.Property(e => e.TokenRejectReasonNo).HasColumnName("TOKEN_REJECT_REASON_NO");

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RegTypeNo).HasColumnName("REG_TYPE_NO");

                entity.Property(e => e.RejectReason)
                    .IsRequired()
                    .HasColumnName("REJECT_REASON")
                    .HasMaxLength(200);

                entity.Property(e => e.SlNo).HasColumnName("SL_NO");

                entity.HasOne(d => d.RegTypeNoNavigation)
                    .WithMany(p => p.GenTokenRejectReason)
                    .HasForeignKey(d => d.RegTypeNo)
                    .HasConstraintName("FK_GEN_TOKEN_REJECT_REASON_GEN_REG_TYPE");
            });

            modelBuilder.Entity<GenUpazilla>(entity =>
            {
                entity.HasKey(e => e.UpzaNo);

                entity.ToTable("GEN_UPAZILLA");

                entity.Property(e => e.UpzaNo).HasColumnName("UPZA_NO");

                entity.Property(e => e.DistNo).HasColumnName("DIST_NO");

                entity.Property(e => e.PoCodeFrom)
                    .HasColumnName("PO_CODE_FROM")
                    .HasMaxLength(50);

                entity.Property(e => e.PoCodeTo)
                    .HasColumnName("PO_CODE_TO")
                    .HasMaxLength(50);

                entity.Property(e => e.UpzaName)
                    .IsRequired()
                    .HasColumnName("UPZA_NAME")
                    .HasMaxLength(100);

                entity.HasOne(d => d.DistNoNavigation)
                    .WithMany(p => p.GenUpazilla)
                    .HasForeignKey(d => d.DistNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_UPAZILLA_GEN_DISTRICT");
            });

            modelBuilder.Entity<GenUploadType>(entity =>
            {
                entity.HasKey(e => e.UploadTypeNo);

                entity.ToTable("GEN_UPLOAD_TYPE");

                entity.Property(e => e.UploadTypeNo)
                    .HasColumnName("UPLOAD_TYPE_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.MaxSizeInMb)
                    .HasColumnName("MAX_SIZE_IN_MB")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxUpload)
                    .HasColumnName("MAX_UPLOAD")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UploadExtList)
                    .IsRequired()
                    .HasColumnName("UPLOAD_EXT_LIST")
                    .HasMaxLength(500);

                entity.Property(e => e.UploadType)
                    .IsRequired()
                    .HasColumnName("UPLOAD_TYPE")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<GenUsersPermissions>(entity =>
            {
                entity.HasKey(e => e.PermitNo);

                entity.ToTable("GEN_USERS_PERMISSIONS");

                entity.HasIndex(e => new { e.UserTypeNo, e.ActionNo })
                    .HasName("IX_GEN_USERS_PERMISSIONS")
                    .IsUnique();

                entity.Property(e => e.PermitNo).HasColumnName("PERMIT_NO");

                entity.Property(e => e.ActionNo).HasColumnName("ACTION_NO");

                entity.Property(e => e.IsAllowed)
                    .HasColumnName("IS_ALLOWED")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UserTypeNo).HasColumnName("USER_TYPE_NO");

                entity.HasOne(d => d.ActionNoNavigation)
                    .WithMany(p => p.GenUsersPermissions)
                    .HasForeignKey(d => d.ActionNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_USERS_PERMISSIONS_GEN_CONTROLLER_ACTION");

                entity.HasOne(d => d.UserTypeNoNavigation)
                    .WithMany(p => p.GenUsersPermissions)
                    .HasForeignKey(d => d.UserTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_USERS_PERMISSIONS_GEN_USER_TYPE");
            });

            modelBuilder.Entity<GenUserType>(entity =>
            {
                entity.HasKey(e => e.UserTypeNo);

                entity.ToTable("GEN_USER_TYPE");

                entity.HasIndex(e => e.UserType)
                    .HasName("IX_GEN_USER_TYPE")
                    .IsUnique();

                entity.Property(e => e.UserTypeNo)
                    .HasColumnName("USER_TYPE_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsLocked)
                    .HasColumnName("IS_LOCKED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxApplication)
                    .HasColumnName("MAX_APPLICATION")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UserType)
                    .IsRequired()
                    .HasColumnName("USER_TYPE")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<GenUserTypeMenus>(entity =>
            {
                entity.HasKey(e => e.UserTypeMenuNo);

                entity.ToTable("GEN_USER_TYPE_MENUS");

                entity.HasIndex(e => new { e.UserTypeNo, e.MenuName })
                    .HasName("IX_GEN_USER_TYPE_MENUS")
                    .IsUnique();

                entity.Property(e => e.UserTypeMenuNo).HasColumnName("USER_TYPE_MENU_NO");

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuName)
                    .HasColumnName("MENU_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.MenuNo).HasColumnName("MENU_NO");

                entity.Property(e => e.MenuUrl)
                    .HasColumnName("MENU_URL")
                    .HasMaxLength(200);

                entity.Property(e => e.SlNo)
                    .HasColumnName("SL_NO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserTypeNo).HasColumnName("USER_TYPE_NO");

                entity.HasOne(d => d.MenuNoNavigation)
                    .WithMany(p => p.GenUserTypeMenus)
                    .HasForeignKey(d => d.MenuNo)
                    .HasConstraintName("FK_GEN_USER_TYPE_MENUS_GEN_MENU_LIST");

                entity.HasOne(d => d.UserTypeNoNavigation)
                    .WithMany(p => p.GenUserTypeMenus)
                    .HasForeignKey(d => d.UserTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_USER_TYPE_MENUS_GEN_USER_TYPE");
            });

            modelBuilder.Entity<GenWorkPermitAuthorityList>(entity =>
            {
                entity.HasKey(e => e.OrgId);

                entity.ToTable("GEN_WORK_PERMIT_AUTHORITY_LIST");

                entity.Property(e => e.OrgId)
                    .HasColumnName("ORG_ID")
                    .HasColumnType("numeric(5, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.OrderBy).HasColumnName("ORDER_BY");

                entity.Property(e => e.OrgName)
                    .IsRequired()
                    .HasColumnName("ORG_NAME")
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<GenWsList>(entity =>
            {
                entity.HasKey(e => e.WsNo);

                entity.ToTable("GEN_WS_LIST");

                entity.Property(e => e.WsNo).HasColumnName("WS_NO");

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasColumnName("CLASS_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Namespace)
                    .IsRequired()
                    .HasColumnName("NAMESPACE")
                    .HasMaxLength(100);

                entity.Property(e => e.WsName)
                    .IsRequired()
                    .HasColumnName("WS_NAME")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<GenWsUserTypes>(entity =>
            {
                entity.HasKey(e => e.WsUserTypeNo);

                entity.ToTable("GEN_WS_USER_TYPES");

                entity.Property(e => e.WsUserTypeNo).HasColumnName("WS_USER_TYPE_NO");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("IS_ACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UserTypeNo).HasColumnName("USER_TYPE_NO");

                entity.Property(e => e.WsNo).HasColumnName("WS_NO");

                entity.HasOne(d => d.UserTypeNoNavigation)
                    .WithMany(p => p.GenWsUserTypes)
                    .HasForeignKey(d => d.UserTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_WS_USER_TYPES_GEN_USER_TYPE");

                entity.HasOne(d => d.WsNoNavigation)
                    .WithMany(p => p.GenWsUserTypes)
                    .HasForeignKey(d => d.WsNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_WS_USER_TYPES_GEN_WS_LIST");
            });

            modelBuilder.Entity<GenZoneInfo>(entity =>
            {
                entity.HasKey(e => e.ZoneNo);

                entity.ToTable("GEN_ZONE_INFO");

                entity.HasIndex(e => e.ZoneName)
                    .HasName("IX_GEN_ZONE_INFO")
                    .IsUnique();

                entity.Property(e => e.ZoneNo).HasColumnName("ZONE_NO");

                entity.Property(e => e.AdmAddr)
                    .HasColumnName("ADM_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.AdmContact)
                    .HasColumnName("ADM_CONTACT")
                    .HasMaxLength(500);

                entity.Property(e => e.AdmName)
                    .HasColumnName("ADM_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.DistNo).HasColumnName("DIST_NO");

                entity.Property(e => e.PayCodeComp)
                    .HasColumnName("PAY_CODE_COMP")
                    .HasMaxLength(100);

                entity.Property(e => e.PayCodeInd)
                    .HasColumnName("PAY_CODE_IND")
                    .HasMaxLength(100);

                entity.Property(e => e.PayCodeOth)
                    .HasColumnName("PAY_CODE_OTH")
                    .HasMaxLength(100);

                entity.Property(e => e.PaymentCode)
                    .HasColumnName("PAYMENT_CODE")
                    .HasMaxLength(100);

                entity.Property(e => e.PaymentCode1)
                    .HasColumnName("PAYMENT_CODE_1")
                    .HasMaxLength(100);

                entity.Property(e => e.PaymentCode2)
                    .HasColumnName("PAYMENT_CODE_2")
                    .HasMaxLength(100);

                entity.Property(e => e.ZoneCode)
                    .HasColumnName("ZONE_CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.ZoneName)
                    .IsRequired()
                    .HasColumnName("ZONE_NAME")
                    .HasMaxLength(100);

                entity.HasOne(d => d.DistNoNavigation)
                    .WithMany(p => p.GenZoneInfo)
                    .HasForeignKey(d => d.DistNo)
                    .HasConstraintName("FK_GEN_ZONE_INFO_GEN_ZONE_INFO");
            });

            modelBuilder.Entity<NbrAddrHistory>(entity =>
            {
                entity.HasKey(e => e.AddrHisNo);

                entity.ToTable("NBR_ADDR_HISTORY");

                entity.Property(e => e.AddrHisNo).HasColumnName("ADDR_HIS_NO");

                entity.Property(e => e.Addr)
                    .IsRequired()
                    .HasColumnName("ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.Addr1)
                    .HasColumnName("ADDR1")
                    .HasMaxLength(500);

                entity.Property(e => e.AddrInfoNo).HasColumnName("ADDR_INFO_NO");

                entity.Property(e => e.AddrTypeNo).HasColumnName("ADDR_TYPE_NO");

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactUpdateReasonNo).HasColumnName("CONTACT_UPDATE_REASON_NO");

                entity.Property(e => e.CountNo).HasColumnName("COUNT_NO");

                entity.Property(e => e.DistNo).HasColumnName("DIST_NO");

                entity.Property(e => e.InsertTime)
                    .HasColumnName("INSERT_TIME")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsImported)
                    .HasColumnName("IS_IMPORTED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JuriSelectListNo).HasColumnName("JURI_SELECT_LIST_NO");

                entity.Property(e => e.JuriSubListNo).HasColumnName("JURI_SUB_LIST_NO");

                entity.Property(e => e.PostCode)
                    .HasColumnName("POST_CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasMaxLength(100);

                entity.Property(e => e.ThanaNo).HasColumnName("THANA_NO");

                entity.Property(e => e.UpdateLogonHisNo).HasColumnName("UPDATE_LOGON_HIS_NO");

                entity.Property(e => e.UpdateReason)
                    .HasColumnName("UPDATE_REASON")
                    .HasMaxLength(500);

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserNo).HasColumnName("UPDATE_USER_NO");

                entity.Property(e => e.UpzaNo).HasColumnName("UPZA_NO");

                entity.Property(e => e.ZipCode)
                    .HasColumnName("ZIP_CODE")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<NbrAddrInfo>(entity =>
            {
                entity.HasKey(e => e.AddrInfoNo);

                entity.ToTable("NBR_ADDR_INFO");

                entity.HasIndex(e => new { e.TinInfoNo, e.AddrTypeNo })
                    .HasName("IX_NBR_ADDR_INFO")
                    .IsUnique();

                entity.Property(e => e.AddrInfoNo).HasColumnName("ADDR_INFO_NO");

                entity.Property(e => e.Addr)
                    .IsRequired()
                    .HasColumnName("ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.Addr1)
                    .HasColumnName("ADDR1")
                    .HasMaxLength(500);

                entity.Property(e => e.AddrTypeNo).HasColumnName("ADDR_TYPE_NO");

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactUpdateReasonNo).HasColumnName("CONTACT_UPDATE_REASON_NO");

                entity.Property(e => e.CountNo).HasColumnName("COUNT_NO");

                entity.Property(e => e.DistNo).HasColumnName("DIST_NO");

                entity.Property(e => e.InsertTime)
                    .HasColumnName("INSERT_TIME")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsImported)
                    .HasColumnName("IS_IMPORTED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JuriSelectListNo).HasColumnName("JURI_SELECT_LIST_NO");

                entity.Property(e => e.JuriSubListNo).HasColumnName("JURI_SUB_LIST_NO");

                entity.Property(e => e.PostCode)
                    .HasColumnName("POST_CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasMaxLength(100);

                entity.Property(e => e.ThanaNo).HasColumnName("THANA_NO");

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");

                entity.Property(e => e.UpdateLogonHisNo).HasColumnName("UPDATE_LOGON_HIS_NO");

                entity.Property(e => e.UpdateReason)
                    .HasColumnName("UPDATE_REASON")
                    .HasMaxLength(500);

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserNo).HasColumnName("UPDATE_USER_NO");

                entity.Property(e => e.UpzaNo).HasColumnName("UPZA_NO");

                entity.Property(e => e.ZipCode)
                    .HasColumnName("ZIP_CODE")
                    .HasMaxLength(100);

                entity.HasOne(d => d.AddrTypeNoNavigation)
                    .WithMany(p => p.NbrAddrInfo)
                    .HasForeignKey(d => d.AddrTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_ADDR_INFO_GEN_ADDR_TYPE");

                entity.HasOne(d => d.CountNoNavigation)
                    .WithMany(p => p.NbrAddrInfo)
                    .HasForeignKey(d => d.CountNo)
                    .HasConstraintName("FK_NBR_ADDR_INFO_GEN_COUNTRY");

                entity.HasOne(d => d.DistNoNavigation)
                    .WithMany(p => p.NbrAddrInfo)
                    .HasForeignKey(d => d.DistNo)
                    .HasConstraintName("FK_NBR_ADDR_INFO_GEN_DISTRICT");

                entity.HasOne(d => d.JuriSelectListNoNavigation)
                    .WithMany(p => p.NbrAddrInfo)
                    .HasForeignKey(d => d.JuriSelectListNo)
                    .HasConstraintName("FK_NBR_ADDR_INFO_GEN_JURI_SELECT_LIST");

                entity.HasOne(d => d.JuriSubListNoNavigation)
                    .WithMany(p => p.NbrAddrInfo)
                    .HasForeignKey(d => d.JuriSubListNo)
                    .HasConstraintName("FK_NBR_ADDR_INFO_GEN_JURI_SUB_LIST");

                entity.HasOne(d => d.ThanaNoNavigation)
                    .WithMany(p => p.NbrAddrInfo)
                    .HasForeignKey(d => d.ThanaNo)
                    .HasConstraintName("FK_NBR_ADDR_INFO_GEN_THANA");

                entity.HasOne(d => d.TinInfoNoNavigation)
                    .WithMany(p => p.NbrAddrInfo)
                    .HasForeignKey(d => d.TinInfoNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_ADDR_INFO_NBR_TIN_INFO");

                entity.HasOne(d => d.UpzaNoNavigation)
                    .WithMany(p => p.NbrAddrInfo)
                    .HasForeignKey(d => d.UpzaNo)
                    .HasConstraintName("FK_NBR_ADDR_INFO_GEN_UPAZILLA");
            });

            modelBuilder.Entity<NbrAddrReq>(entity =>
            {
                entity.HasKey(e => e.AddrReqNo);

                entity.ToTable("NBR_ADDR_REQ");

                entity.Property(e => e.AddrReqNo).HasColumnName("ADDR_REQ_NO");

                entity.Property(e => e.Addr)
                    .IsRequired()
                    .HasColumnName("ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.Addr1)
                    .HasColumnName("ADDR1")
                    .HasMaxLength(500);

                entity.Property(e => e.AddrTypeNo).HasColumnName("ADDR_TYPE_NO");

                entity.Property(e => e.ApproveLogonNo).HasColumnName("APPROVE_LOGON_NO");

                entity.Property(e => e.ApproveStatusNum).HasColumnName("APPROVE_STATUS_NUM");

                entity.Property(e => e.ApproveTime)
                    .HasColumnName("APPROVE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApproveUserNo).HasColumnName("APPROVE_USER_NO");

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactUpdateReasonNo).HasColumnName("CONTACT_UPDATE_REASON_NO");

                entity.Property(e => e.CountNo).HasColumnName("COUNT_NO");

                entity.Property(e => e.DistNo).HasColumnName("DIST_NO");

                entity.Property(e => e.InsertTime)
                    .HasColumnName("INSERT_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsImported).HasColumnName("IS_IMPORTED");

                entity.Property(e => e.JuriSelectListNo).HasColumnName("JURI_SELECT_LIST_NO");

                entity.Property(e => e.JuriSubListNo).HasColumnName("JURI_SUB_LIST_NO");

                entity.Property(e => e.PostCode)
                    .HasColumnName("POST_CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.ReqLogonNo).HasColumnName("REQ_LOGON_NO");

                entity.Property(e => e.ReqNo).HasColumnName("REQ_NO");

                entity.Property(e => e.ReqTime)
                    .HasColumnName("REQ_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReqUserNo).HasColumnName("REQ_USER_NO");

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasMaxLength(100);

                entity.Property(e => e.ThanaNo).HasColumnName("THANA_NO");

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");

                entity.Property(e => e.UpdateLogonHisNo).HasColumnName("UPDATE_LOGON_HIS_NO");

                entity.Property(e => e.UpdateReason)
                    .HasColumnName("UPDATE_REASON")
                    .HasMaxLength(500);

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserNo).HasColumnName("UPDATE_USER_NO");

                entity.Property(e => e.UpzaNo).HasColumnName("UPZA_NO");

                entity.Property(e => e.ZipCode)
                    .HasColumnName("ZIP_CODE")
                    .HasMaxLength(100);

                entity.HasOne(d => d.ReqNoNavigation)
                    .WithMany(p => p.NbrAddrReq)
                    .HasForeignKey(d => d.ReqNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_ADDR_REQ_NBR_TIN_STATUS_REQ");
            });

            modelBuilder.Entity<NbrAdtBusi>(entity =>
            {
                entity.HasKey(e => e.BusiNo);

                entity.ToTable("NBR_ADT_BUSI");

                entity.Property(e => e.BusiNo).HasColumnName("BUSI_NO");

                entity.Property(e => e.BusinessName)
                    .IsRequired()
                    .HasColumnName("BUSINESS_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.InsertLogonNo).HasColumnName("INSERT_LOGON_NO");

                entity.Property(e => e.InsertTime)
                    .HasColumnName("INSERT_TIME")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUserNo).HasColumnName("INSERT_USER_NO");

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.TinInfoNoNavigation)
                    .WithMany(p => p.NbrAdtBusi)
                    .HasForeignKey(d => d.TinInfoNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_ADT_BUSI_NBR_TIN_INFO");
            });

            modelBuilder.Entity<NbrAdtBusiHis>(entity =>
            {
                entity.HasKey(e => e.BusiHisNo);

                entity.ToTable("NBR_ADT_BUSI_HIS");

                entity.Property(e => e.BusiHisNo).HasColumnName("BUSI_HIS_NO");

                entity.Property(e => e.BusiNo).HasColumnName("BUSI_NO");

                entity.Property(e => e.BusinessName)
                    .IsRequired()
                    .HasColumnName("BUSINESS_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.DeleteLogonNo).HasColumnName("DELETE_LOGON_NO");

                entity.Property(e => e.DeleteTime)
                    .HasColumnName("DELETE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeleteUserNo).HasColumnName("DELETE_USER_NO");

                entity.Property(e => e.InsertLogonNo).HasColumnName("INSERT_LOGON_NO");

                entity.Property(e => e.InsertTime)
                    .HasColumnName("INSERT_TIME")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUserNo).HasColumnName("INSERT_USER_NO");

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<NbrContactHistory>(entity =>
            {
                entity.HasKey(e => e.ContactHisNo);

                entity.ToTable("NBR_CONTACT_HISTORY");

                entity.Property(e => e.ContactHisNo).HasColumnName("CONTACT_HIS_NO");

                entity.Property(e => e.BoiDate)
                    .HasColumnName("BOI_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.BoiNumber)
                    .HasColumnName("BOI_NUMBER")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactEmailAddr)
                    .HasColumnName("CONTACT_EMAIL_ADDR")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactFax)
                    .HasColumnName("CONTACT_FAX")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactTelephone)
                    .HasColumnName("CONTACT_TELEPHONE")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactUpdateReasonNo).HasColumnName("CONTACT_UPDATE_REASON_NO");

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("UPDATE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateLogonHisNo).HasColumnName("UPDATE_LOGON_HIS_NO");

                entity.Property(e => e.UpdateReason)
                    .HasColumnName("UPDATE_REASON")
                    .HasMaxLength(500);

                entity.Property(e => e.UpdateUserNo).HasColumnName("UPDATE_USER_NO");

                entity.HasOne(d => d.TinInfoNoNavigation)
                    .WithMany(p => p.NbrContactHistory)
                    .HasForeignKey(d => d.TinInfoNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_CONTACT_HISTORY_NBR_TIN_INFO");
            });

            modelBuilder.Entity<NbrEcHistory>(entity =>
            {
                entity.HasKey(e => e.EcHisNo);

                entity.ToTable("NBR_EC_HISTORY");

                entity.Property(e => e.EcHisNo).HasColumnName("EC_HIS_NO");

                entity.Property(e => e.CreateLogonHisNo).HasColumnName("CREATE_LOGON_HIS_NO");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("CREATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserNo).HasColumnName("CREATE_USER_NO");

                entity.Property(e => e.IsSmartApply)
                    .HasColumnName("IS_SMART_APPLY")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NidBfathName)
                    .HasColumnName("NID_BFATH_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NidBmothName)
                    .HasColumnName("NID_BMOTH_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NidBname)
                    .HasColumnName("NID_BNAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NidBperAddr)
                    .HasColumnName("NID_BPER_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.NidBpreAddr)
                    .HasColumnName("NID_BPRE_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.NidBspouseName)
                    .HasColumnName("NID_BSPOUSE_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NidDob)
                    .HasColumnName("NID_DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.NidName)
                    .HasColumnName("NID_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NidPhoto).HasColumnName("NID_PHOTO");

                entity.Property(e => e.NidTitle)
                    .HasColumnName("NID_TITLE")
                    .HasMaxLength(500);

                entity.Property(e => e.SmartId)
                    .HasColumnName("SMART_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");

                entity.HasOne(d => d.TinInfoNoNavigation)
                    .WithMany(p => p.NbrEcHistory)
                    .HasForeignKey(d => d.TinInfoNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_EC_HISTORY_NBR_TIN_INFO");
            });

            modelBuilder.Entity<NbrFeedBack>(entity =>
            {
                entity.HasKey(e => e.FeedBackNo);

                entity.ToTable("NBR_FEED_BACK");

                entity.Property(e => e.FeedBackNo).HasColumnName("FEED_BACK_NO");

                entity.Property(e => e.FComments)
                    .IsRequired()
                    .HasColumnName("F_COMMENTS")
                    .HasMaxLength(500);

                entity.Property(e => e.FSubject)
                    .IsRequired()
                    .HasColumnName("F_SUBJECT")
                    .HasMaxLength(100);

                entity.Property(e => e.InsertTime)
                    .HasColumnName("INSERT_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsRead).HasColumnName("IS_READ");

                entity.Property(e => e.LogonHisNo).HasColumnName("LOGON_HIS_NO");

                entity.Property(e => e.ReadLogonHisNo).HasColumnName("READ_LOGON_HIS_NO");

                entity.Property(e => e.ReadTime)
                    .HasColumnName("READ_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReadUserNo).HasColumnName("READ_USER_NO");

                entity.Property(e => e.UserNo).HasColumnName("USER_NO");

                entity.HasOne(d => d.UserNoNavigation)
                    .WithMany(p => p.NbrFeedBack)
                    .HasForeignKey(d => d.UserNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_FEED_BACK_NBR_USERS");
            });

            modelBuilder.Entity<NbrInfoEditRequest>(entity =>
            {
                entity.HasKey(e => e.RequestNo);

                entity.ToTable("NBR_INFO_EDIT_REQUEST");

                entity.HasIndex(e => e.RequestTime)
                    .HasName("IX_NBR_INFO_EDIT_REQUEST");

                entity.Property(e => e.RequestNo).HasColumnName("REQUEST_NO");

                entity.Property(e => e.Addr)
                    .HasColumnName("ADDR")
                    .HasMaxLength(1000);

                entity.Property(e => e.Addr1)
                    .HasColumnName("ADDR1")
                    .HasMaxLength(1000);

                entity.Property(e => e.AddrCity)
                    .HasColumnName("ADDR_CITY")
                    .HasMaxLength(200);

                entity.Property(e => e.AddrCountNo).HasColumnName("ADDR_COUNT_NO");

                entity.Property(e => e.AddrDistNo).HasColumnName("ADDR_DIST_NO");

                entity.Property(e => e.AddrPostCode)
                    .HasColumnName("ADDR_POST_CODE")
                    .HasMaxLength(100);

                entity.Property(e => e.AddrState)
                    .HasColumnName("ADDR_STATE")
                    .HasMaxLength(200);

                entity.Property(e => e.AddrThanaNo).HasColumnName("ADDR_THANA_NO");

                entity.Property(e => e.AddrUpzaNo).HasColumnName("ADDR_UPZA_NO");

                entity.Property(e => e.AddrZipCode)
                    .HasColumnName("ADDR_ZIP_CODE")
                    .HasMaxLength(200);

                entity.Property(e => e.ApproveComments)
                    .HasColumnName("APPROVE_COMMENTS")
                    .HasMaxLength(1000);

                entity.Property(e => e.ApproveLogonNo).HasColumnName("APPROVE_LOGON_NO");

                entity.Property(e => e.ApproveTime)
                    .HasColumnName("APPROVE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApproveUserNo).HasColumnName("APPROVE_USER_NO");

                entity.Property(e => e.AssesName)
                    .HasColumnName("ASSES_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.BoiDate)
                    .HasColumnName("BOI_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.BoiNumber)
                    .HasColumnName("BOI_NUMBER")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactEmailAddr)
                    .HasColumnName("CONTACT_EMAIL_ADDR")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactFax)
                    .HasColumnName("CONTACT_FAX")
                    .HasMaxLength(100);

                entity.Property(e => e.CountNo).HasColumnName("COUNT_NO");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.EditReason)
                    .HasColumnName("EDIT_REASON")
                    .HasMaxLength(1000);

                entity.Property(e => e.EditTypeNo).HasColumnName("EDIT_TYPE_NO");

                entity.Property(e => e.EscalateComments)
                    .HasColumnName("ESCALATE_COMMENTS")
                    .HasMaxLength(1000);

                entity.Property(e => e.EscalateLogonNo).HasColumnName("ESCALATE_LOGON_NO");

                entity.Property(e => e.EscalateTime)
                    .HasColumnName("ESCALATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.EscalateUserNo).HasColumnName("ESCALATE_USER_NO");

                entity.Property(e => e.FathName)
                    .HasColumnName("FATH_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.GenderNum).HasColumnName("GENDER_NUM");

                entity.Property(e => e.GuardTin)
                    .HasColumnName("GUARD_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.IsApprove).HasColumnName("IS_APPROVE");

                entity.Property(e => e.IsEscalate).HasColumnName("IS_ESCALATE");

                entity.Property(e => e.IsOldTin).HasColumnName("IS_OLD_TIN");

                entity.Property(e => e.IsVerify).HasColumnName("IS_VERIFY");

                entity.Property(e => e.IsView).HasColumnName("IS_VIEW");

                entity.Property(e => e.MothName)
                    .HasColumnName("MOTH_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.OldTin)
                    .HasColumnName("OLD_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.PassportIssueDate)
                    .HasColumnName("PASSPORT_ISSUE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PassportNumber)
                    .HasColumnName("PASSPORT_NUMBER")
                    .HasMaxLength(100);

                entity.Property(e => e.RelevantTin)
                    .HasColumnName("RELEVANT_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.RequestLogonNo).HasColumnName("REQUEST_LOGON_NO");

                entity.Property(e => e.RequestTime)
                    .HasColumnName("REQUEST_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestUserNo).HasColumnName("REQUEST_USER_NO");

                entity.Property(e => e.SpouseName)
                    .HasColumnName("SPOUSE_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");

                entity.Property(e => e.VerifyComments)
                    .HasColumnName("VERIFY_COMMENTS")
                    .HasMaxLength(1000);

                entity.Property(e => e.VerifyLogonNo).HasColumnName("VERIFY_LOGON_NO");

                entity.Property(e => e.VerifyTime)
                    .HasColumnName("VERIFY_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.VerifyUserNo).HasColumnName("VERIFY_USER_NO");

                entity.Property(e => e.ViewLogonNo).HasColumnName("VIEW_LOGON_NO");

                entity.Property(e => e.ViewTime)
                    .HasColumnName("VIEW_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ViewUserNo).HasColumnName("VIEW_USER_NO");

                entity.Property(e => e.VisaDate)
                    .HasColumnName("VISA_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.VisaNumber)
                    .HasColumnName("VISA_NUMBER")
                    .HasMaxLength(500);

                entity.HasOne(d => d.AddrCountNoNavigation)
                    .WithMany(p => p.NbrInfoEditRequestAddrCountNoNavigation)
                    .HasForeignKey(d => d.AddrCountNo)
                    .HasConstraintName("FK_NBR_INFO_EDIT_REQUEST_GEN_COUNTRY");

                entity.HasOne(d => d.AddrDistNoNavigation)
                    .WithMany(p => p.NbrInfoEditRequest)
                    .HasForeignKey(d => d.AddrDistNo)
                    .HasConstraintName("FK_NBR_INFO_EDIT_REQUEST_GEN_DISTRICT");

                entity.HasOne(d => d.AddrThanaNoNavigation)
                    .WithMany(p => p.NbrInfoEditRequest)
                    .HasForeignKey(d => d.AddrThanaNo)
                    .HasConstraintName("FK_NBR_INFO_EDIT_REQUEST_GEN_THANA");

                entity.HasOne(d => d.CountNoNavigation)
                    .WithMany(p => p.NbrInfoEditRequestCountNoNavigation)
                    .HasForeignKey(d => d.CountNo);

                entity.HasOne(d => d.EditTypeNoNavigation)
                    .WithMany(p => p.NbrInfoEditRequest)
                    .HasForeignKey(d => d.EditTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_INFO_EDIT_REQUEST_GEN_EDIT_TYPES");

                entity.HasOne(d => d.TinInfoNoNavigation)
                    .WithMany(p => p.NbrInfoEditRequest)
                    .HasForeignKey(d => d.TinInfoNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_INFO_EDIT_REQUEST_NBR_TIN_INFO");
            });

            modelBuilder.Entity<NbrInfoUpdate>(entity =>
            {
                entity.HasKey(e => e.InfoUpdateNo);

                entity.ToTable("NBR_INFO_UPDATE");

                entity.Property(e => e.InfoUpdateNo).HasColumnName("INFO_UPDATE_NO");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasColumnName("FIELD_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.LogonHisNo).HasColumnName("LOGON_HIS_NO");

                entity.Property(e => e.NewValue)
                    .HasColumnName("NEW_VALUE")
                    .HasMaxLength(500);

                entity.Property(e => e.OldValue)
                    .HasColumnName("OLD_VALUE")
                    .HasMaxLength(500);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasColumnName("TABLE_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserNo).HasColumnName("USER_NO");

                entity.HasOne(d => d.TinInfoNoNavigation)
                    .WithMany(p => p.NbrInfoUpdate)
                    .HasForeignKey(d => d.TinInfoNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_INFO_UPDATE_NBR_TIN_INFO");
            });

            modelBuilder.Entity<NbrInvalidActivate>(entity =>
            {
                entity.HasKey(e => e.InvalidNo);

                entity.ToTable("NBR_INVALID_ACTIVATE");

                entity.Property(e => e.InvalidNo).HasColumnName("INVALID_NO");

                entity.Property(e => e.ActivationType)
                    .HasColumnName("ACTIVATION_TYPE")
                    .HasMaxLength(100);

                entity.Property(e => e.EmailActivateCode)
                    .HasColumnName("EMAIL_ACTIVATE_CODE")
                    .HasMaxLength(100);

                entity.Property(e => e.EmailActivateTime)
                    .HasColumnName("EMAIL_ACTIVATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmailActiveIpAddr)
                    .HasColumnName("EMAIL_ACTIVE_IP_ADDR")
                    .HasMaxLength(100);

                entity.Property(e => e.LogonName)
                    .IsRequired()
                    .HasColumnName("LOGON_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.MobileActivateCode)
                    .HasColumnName("MOBILE_ACTIVATE_CODE")
                    .HasMaxLength(100);

                entity.Property(e => e.MobileActivateTime)
                    .HasColumnName("MOBILE_ACTIVATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.MobileActiveIpAddr)
                    .HasColumnName("MOBILE_ACTIVE_IP_ADDR")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<NbrInvalidLogins>(entity =>
            {
                entity.HasKey(e => e.InvalidLoginNo);

                entity.ToTable("NBR_INVALID_LOGINS");

                entity.Property(e => e.InvalidLoginNo).HasColumnName("INVALID_LOGIN_NO");

                entity.Property(e => e.AccessTime)
                    .HasColumnName("ACCESS_TIME")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IpAddr)
                    .IsRequired()
                    .HasColumnName("IP_ADDR")
                    .HasMaxLength(100);

                entity.Property(e => e.LogonName)
                    .IsRequired()
                    .HasColumnName("LOGON_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.LogonPass)
                    .HasColumnName("LOGON_PASS")
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<NbrJurisdictionTransfer>(entity =>
            {
                entity.HasKey(e => e.TrasferNo);

                entity.ToTable("NBR_JURISDICTION_TRANSFER");

                entity.HasIndex(e => new { e.TinInfoNo, e.IsLocked })
                    .HasName("IX_JURISDICTION_TRANSFER_GET");

                entity.Property(e => e.TrasferNo).HasColumnName("TRASFER_NO");

                entity.Property(e => e.ApproveComments)
                    .HasColumnName("APPROVE_COMMENTS")
                    .HasMaxLength(1000);

                entity.Property(e => e.ApproveLogonHisNo).HasColumnName("APPROVE_LOGON_HIS_NO");

                entity.Property(e => e.ApproveTime)
                    .HasColumnName("APPROVE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApproveUserNo).HasColumnName("APPROVE_USER_NO");

                entity.Property(e => e.DestCircleNo).HasColumnName("DEST_CIRCLE_NO");

                entity.Property(e => e.DestComments)
                    .HasColumnName("DEST_COMMENTS")
                    .HasMaxLength(1000);

                entity.Property(e => e.DestIsAccept)
                    .HasColumnName("DEST_IS_ACCEPT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DestLogonHisNo).HasColumnName("DEST_LOGON_HIS_NO");

                entity.Property(e => e.DestTime)
                    .HasColumnName("DEST_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.DestUserNo).HasColumnName("DEST_USER_NO");

                entity.Property(e => e.FinalComments)
                    .HasColumnName("FINAL_COMMENTS")
                    .HasMaxLength(1000);

                entity.Property(e => e.FinalLogonHisNo).HasColumnName("FINAL_LOGON_HIS_NO");

                entity.Property(e => e.FinalTime)
                    .HasColumnName("FINAL_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.FinalUserNo).HasColumnName("FINAL_USER_NO");

                entity.Property(e => e.InsertTime)
                    .HasColumnName("INSERT_TIME")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsApproved)
                    .HasColumnName("IS_APPROVED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFinalChanged)
                    .HasColumnName("IS_FINAL_CHANGED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsLocked)
                    .HasColumnName("IS_LOCKED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsRaisedByApplicant)
                    .HasColumnName("IS_RAISED_BY_APPLICANT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JuriListName)
                    .HasColumnName("JURI_LIST_NAME")
                    .HasMaxLength(400);

                entity.Property(e => e.JuriSelectListNo).HasColumnName("JURI_SELECT_LIST_NO");

                entity.Property(e => e.JuriSelectTypeNo).HasColumnName("JURI_SELECT_TYPE_NO");

                entity.Property(e => e.JuriSubListName)
                    .HasColumnName("JURI_SUB_LIST_NAME")
                    .HasMaxLength(400);

                entity.Property(e => e.JuriSubListNo).HasColumnName("JURI_SUB_LIST_NO");

                entity.Property(e => e.JuriTypeNo).HasColumnName("JURI_TYPE_NO");

                entity.Property(e => e.RaiseComments)
                    .HasColumnName("RAISE_COMMENTS")
                    .HasMaxLength(1000);

                entity.Property(e => e.RaiseLogonHisNo).HasColumnName("RAISE_LOGON_HIS_NO");

                entity.Property(e => e.RaiseTime)
                    .HasColumnName("RAISE_TIME")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RaiseUserNo).HasColumnName("RAISE_USER_NO");

                entity.Property(e => e.RegJuriTypeNo).HasColumnName("REG_JURI_TYPE_NO");

                entity.Property(e => e.SrcCircleNo).HasColumnName("SRC_CIRCLE_NO");

                entity.Property(e => e.SrcComments)
                    .HasColumnName("SRC_COMMENTS")
                    .HasMaxLength(1000);

                entity.Property(e => e.SrcIsNoc)
                    .HasColumnName("SRC_IS_NOC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SrcLogonHisNo).HasColumnName("SRC_LOGON_HIS_NO");

                entity.Property(e => e.SrcTime)
                    .HasColumnName("SRC_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.SrcUserNo).HasColumnName("SRC_USER_NO");

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.TinInfoNoNavigation)
                    .WithMany(p => p.NbrJurisdictionTransfer)
                    .HasForeignKey(d => d.TinInfoNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_JURISDICTION_TRANSFER_NBR_TIN_INFO");
            });

            modelBuilder.Entity<NbrMobileHis>(entity =>
            {
                entity.HasKey(e => e.MobHisNo);

                entity.ToTable("NBR_MOBILE_HIS");

                entity.HasIndex(e => e.Mobile)
                    .HasName("IX_NBR_MOBILE_HIS_GET");

                entity.Property(e => e.MobHisNo).HasColumnName("MOB_HIS_NO");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("CREATED_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasColumnName("MOBILE")
                    .HasMaxLength(100);

                entity.Property(e => e.UserNo).HasColumnName("USER_NO");

                entity.HasOne(d => d.UserNoNavigation)
                    .WithMany(p => p.NbrMobileHis)
                    .HasForeignKey(d => d.UserNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_MOBILE_HIS_NBR_USERS");
            });

            modelBuilder.Entity<NbrMobileRequest>(entity =>
            {
                entity.HasKey(e => e.ReqMobNo);

                entity.ToTable("NBR_MOBILE_REQUEST");

                entity.HasIndex(e => e.ReqMob)
                    .HasName("IX_NBR_MOBILE_REQUEST");

                entity.Property(e => e.ReqMobNo).HasColumnName("REQ_MOB_NO");

                entity.Property(e => e.ActivateCode)
                    .HasColumnName("ACTIVATE_CODE")
                    .HasMaxLength(1000);

                entity.Property(e => e.ActivateIpAddress)
                    .HasColumnName("ACTIVATE_IP_ADDRESS")
                    .HasMaxLength(1000);

                entity.Property(e => e.ActivateUserNo).HasColumnName("ACTIVATE_USER_NO");

                entity.Property(e => e.ActivationTime)
                    .HasColumnName("ACTIVATION_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ActiveLogonNo).HasColumnName("ACTIVE_LOGON_NO");

                entity.Property(e => e.CancelIpAddress)
                    .HasColumnName("CANCEL_IP_ADDRESS")
                    .HasMaxLength(1000);

                entity.Property(e => e.CancelLogonNo).HasColumnName("CANCEL_LOGON_NO");

                entity.Property(e => e.CancelTime)
                    .HasColumnName("CANCEL_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CancelUserNo).HasColumnName("CANCEL_USER_NO");

                entity.Property(e => e.CountryCode)
                    .HasColumnName("COUNTRY_CODE")
                    .HasMaxLength(100);

                entity.Property(e => e.IsActivated).HasColumnName("IS_ACTIVATED");

                entity.Property(e => e.IsCancel).HasColumnName("IS_CANCEL");

                entity.Property(e => e.ReqIpAddress)
                    .HasColumnName("REQ_IP_ADDRESS")
                    .HasMaxLength(1000);

                entity.Property(e => e.ReqLogonNo).HasColumnName("REQ_LOGON_NO");

                entity.Property(e => e.ReqMob)
                    .IsRequired()
                    .HasColumnName("REQ_MOB")
                    .HasMaxLength(50);

                entity.Property(e => e.ReqTime)
                    .HasColumnName("REQ_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReqUserNo).HasColumnName("REQ_USER_NO");

                entity.Property(e => e.UserNo).HasColumnName("USER_NO");

                entity.HasOne(d => d.UserNoNavigation)
                    .WithMany(p => p.NbrMobileRequest)
                    .HasForeignKey(d => d.UserNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_MOBILE_REQUEST_NBR_USERS");
            });

            modelBuilder.Entity<NbrNidDup>(entity =>
            {
                entity.HasKey(e => e.DupNo);

                entity.ToTable("NBR_NID_DUP");

                entity.Property(e => e.DupNo).HasColumnName("DUP_NO");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("CATEGORY")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'NID')");

                entity.Property(e => e.Nid)
                    .IsRequired()
                    .HasColumnName("NID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NbrPassRecovery>(entity =>
            {
                entity.HasKey(e => e.RequestNo);

                entity.ToTable("NBR_PASS_RECOVERY");

                entity.HasIndex(e => new { e.UserNo, e.RequestDate })
                    .HasName("IX_NBR_PASS_RECOVERY_SMS_COUNT");

                entity.Property(e => e.RequestNo).HasColumnName("REQUEST_NO");

                entity.Property(e => e.DeliveryTime)
                    .HasColumnName("DELIVERY_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.IpAddr)
                    .IsRequired()
                    .HasColumnName("IP_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.IsDelivered)
                    .HasColumnName("IS_DELIVERED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobId)
                    .HasColumnName("JOB_ID")
                    .HasMaxLength(500);

                entity.Property(e => e.MobPass)
                    .IsRequired()
                    .HasColumnName("MOB_PASS")
                    .HasMaxLength(500);

                entity.Property(e => e.RecoverTypeNum).HasColumnName("RECOVER_TYPE_NUM");

                entity.Property(e => e.RequestDate)
                    .HasColumnName("REQUEST_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.RequestTime)
                    .HasColumnName("REQUEST_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserNo).HasColumnName("USER_NO");

                entity.HasOne(d => d.UserNoNavigation)
                    .WithMany(p => p.NbrPassRecovery)
                    .HasForeignKey(d => d.UserNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_PASS_RECOVERY_NBR_USERS");
            });

            modelBuilder.Entity<NbrRjscHis>(entity =>
            {
                entity.HasKey(e => e.RjscHisNo);

                entity.ToTable("NBR_RJSC_HIS");

                entity.Property(e => e.RjscHisNo).HasColumnName("RJSC_HIS_NO");

                entity.Property(e => e.BusiInfoNo).HasColumnName("BUSI_INFO_NO");

                entity.Property(e => e.BusiName)
                    .HasColumnName("BUSI_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.BusiTin)
                    .HasColumnName("BUSI_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.BusiTypeNo).HasColumnName("BUSI_TYPE_NO");

                entity.Property(e => e.CountryName)
                    .HasColumnName("COUNTRY_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.CreateLogonHisNo).HasColumnName("CREATE_LOGON_HIS_NO");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("CREATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserNo).HasColumnName("CREATE_USER_NO");

                entity.Property(e => e.EcDob)
                    .HasColumnName("EC_DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.EcName)
                    .HasColumnName("EC_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.EcNid)
                    .HasColumnName("EC_NID")
                    .HasMaxLength(100);

                entity.Property(e => e.EcTitle)
                    .HasColumnName("EC_TITLE")
                    .HasMaxLength(500);

                entity.Property(e => e.InsertTime)
                    .HasColumnName("INSERT_TIME")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsImported)
                    .HasColumnName("IS_IMPORTED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OldTinBusiName)
                    .HasColumnName("OLD_TIN_BUSI_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.OldTinBusiTin)
                    .HasColumnName("OLD_TIN_BUSI_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.RjscBusiName)
                    .HasColumnName("RJSC_BUSI_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.RjscBusiTin)
                    .HasColumnName("RJSC_BUSI_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.RjscMasHisNo).HasColumnName("RJSC_MAS_HIS_NO");

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.RjscMasHisNoNavigation)
                    .WithMany(p => p.NbrRjscHis)
                    .HasForeignKey(d => d.RjscMasHisNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_RJSC_HIS_NBR_RJSC_MASTER_HIS");
            });

            modelBuilder.Entity<NbrRjscMasterHis>(entity =>
            {
                entity.HasKey(e => e.RjscMasHisNo);

                entity.ToTable("NBR_RJSC_MASTER_HIS");

                entity.Property(e => e.RjscMasHisNo).HasColumnName("RJSC_MAS_HIS_NO");

                entity.Property(e => e.CreateLogonHisNo).HasColumnName("CREATE_LOGON_HIS_NO");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("CREATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserNo).HasColumnName("CREATE_USER_NO");

                entity.Property(e => e.RjscAddr)
                    .HasColumnName("RJSC_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.RjscName)
                    .HasColumnName("RJSC_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");

                entity.HasOne(d => d.TinInfoNoNavigation)
                    .WithMany(p => p.NbrRjscMasterHis)
                    .HasForeignKey(d => d.TinInfoNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_RJSC_MASTER_HIS_NBR_TIN_INFO");
            });

            modelBuilder.Entity<NbrSmsSend>(entity =>
            {
                entity.HasKey(e => e.SendReqNo);

                entity.ToTable("NBR_SMS_SEND");

                entity.Property(e => e.SendReqNo).HasColumnName("SEND_REQ_NO");

                entity.Property(e => e.ActionName)
                    .IsRequired()
                    .HasColumnName("ACTION_NAME")
                    .HasMaxLength(1000);

                entity.Property(e => e.ActivationCode)
                    .HasColumnName("ACTIVATION_CODE")
                    .HasMaxLength(1000);

                entity.Property(e => e.ActualSms)
                    .IsRequired()
                    .HasColumnName("ACTUAL_SMS")
                    .HasMaxLength(1000);

                entity.Property(e => e.CountCode)
                    .IsRequired()
                    .HasColumnName("COUNT_CODE")
                    .HasMaxLength(100);

                entity.Property(e => e.DeliveryTime)
                    .HasColumnName("DELIVERY_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gateway)
                    .HasColumnName("GATEWAY")
                    .HasMaxLength(1000);

                entity.Property(e => e.IpAddr)
                    .HasColumnName("IP_ADDR")
                    .HasMaxLength(1000);

                entity.Property(e => e.IsDelivered)
                    .HasColumnName("IS_DELIVERED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobId)
                    .HasColumnName("JOB_ID")
                    .HasMaxLength(1000);

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasColumnName("MOBILE")
                    .HasMaxLength(100);

                entity.Property(e => e.NetworkProvider)
                    .IsRequired()
                    .HasColumnName("NETWORK_PROVIDER")
                    .HasMaxLength(1000);

                entity.Property(e => e.ReqTypeNum).HasColumnName("REQ_TYPE_NUM");

                entity.Property(e => e.RequestDate)
                    .HasColumnName("REQUEST_DATE")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequestTime)
                    .HasColumnName("REQUEST_TIME")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<NbrTaxpayerUserVerify>(entity =>
            {
                entity.HasKey(e => e.VerifyNo);

                entity.ToTable("NBR_TAXPAYER_USER_VERIFY");

                entity.Property(e => e.VerifyNo).HasColumnName("VERIFY_NO");

                entity.Property(e => e.IsValid).HasColumnName("IS_VALID");

                entity.Property(e => e.TaxpayerName)
                    .HasColumnName("TAXPAYER_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.VerifyTime)
                    .HasColumnName("VERIFY_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.VerifyUserLogonHisNo).HasColumnName("VERIFY_USER_LOGON_HIS_NO");

                entity.Property(e => e.VerifyUserNo).HasColumnName("VERIFY_USER_NO");
            });

            modelBuilder.Entity<NbrTinAttachHis>(entity =>
            {
                entity.HasKey(e => e.AttachHisNo);

                entity.ToTable("NBR_TIN_ATTACH_HIS");

                entity.Property(e => e.AttachHisNo).HasColumnName("ATTACH_HIS_NO");

                entity.Property(e => e.AttachData).HasColumnName("ATTACH_DATA");

                entity.Property(e => e.AttachExt)
                    .IsRequired()
                    .HasColumnName("ATTACH_EXT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AttachName)
                    .IsRequired()
                    .HasColumnName("ATTACH_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.AttachNo).HasColumnName("ATTACH_NO");

                entity.Property(e => e.AttachTypeNo).HasColumnName("ATTACH_TYPE_NO");

                entity.Property(e => e.InsertTime)
                    .HasColumnName("INSERT_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsImported).HasColumnName("IS_IMPORTED");

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");

                entity.Property(e => e.UpdateLogonNo).HasColumnName("UPDATE_LOGON_NO");

                entity.Property(e => e.UpdateReason)
                    .HasColumnName("UPDATE_REASON")
                    .HasMaxLength(2000);

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserNo).HasColumnName("UPDATE_USER_NO");
            });

            modelBuilder.Entity<NbrTinAttachment>(entity =>
            {
                entity.HasKey(e => e.AttachNo);

                entity.ToTable("NBR_TIN_ATTACHMENT");

                entity.HasIndex(e => new { e.AttachNo, e.AttachTypeNo })
                    .HasName("IX_NBR_TIN_ATTACHMENT_GET");

                entity.HasIndex(e => new { e.TinInfoNo, e.AttachTypeNo, e.AttachName })
                    .HasName("IX_NBR_TIN_ATTACHMENT")
                    .IsUnique();

                entity.Property(e => e.AttachNo).HasColumnName("ATTACH_NO");

                entity.Property(e => e.AttachData).HasColumnName("ATTACH_DATA");

                entity.Property(e => e.AttachExt)
                    .IsRequired()
                    .HasColumnName("ATTACH_EXT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AttachName)
                    .IsRequired()
                    .HasColumnName("ATTACH_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.AttachTypeNo).HasColumnName("ATTACH_TYPE_NO");

                entity.Property(e => e.InsertTime)
                    .HasColumnName("INSERT_TIME")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsImported)
                    .HasColumnName("IS_IMPORTED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");

                entity.Property(e => e.UpdateLogonNo).HasColumnName("UPDATE_LOGON_NO");

                entity.Property(e => e.UpdateReason)
                    .HasColumnName("UPDATE_REASON")
                    .HasMaxLength(2000);

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserNo).HasColumnName("UPDATE_USER_NO");

                entity.HasOne(d => d.AttachTypeNoNavigation)
                    .WithMany(p => p.NbrTinAttachment)
                    .HasForeignKey(d => d.AttachTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_TIN_ATTACHMENT_GEN_ATTACH_TYPE");

                entity.HasOne(d => d.TinInfoNoNavigation)
                    .WithMany(p => p.NbrTinAttachment)
                    .HasForeignKey(d => d.TinInfoNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_TIN_ATTACHMENT_NBR_TIN_INFO");
            });

            modelBuilder.Entity<NbrTinBusiHis>(entity =>
            {
                entity.HasKey(e => e.BusiHisNo);

                entity.ToTable("NBR_TIN_BUSI_HIS");

                entity.Property(e => e.BusiHisNo).HasColumnName("BUSI_HIS_NO");

                entity.Property(e => e.BusiInfoNo).HasColumnName("BUSI_INFO_NO");

                entity.Property(e => e.BusiName)
                    .HasColumnName("BUSI_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.BusiTin)
                    .HasColumnName("BUSI_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.BusiTypeNo).HasColumnName("BUSI_TYPE_NO");

                entity.Property(e => e.CountryName)
                    .HasColumnName("COUNTRY_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.EcDob)
                    .HasColumnName("EC_DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.EcName)
                    .HasColumnName("EC_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.EcNid)
                    .HasColumnName("EC_NID")
                    .HasMaxLength(100);

                entity.Property(e => e.EcTitle)
                    .HasColumnName("EC_TITLE")
                    .HasMaxLength(500);

                entity.Property(e => e.InsertTime)
                    .HasColumnName("INSERT_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsImported).HasColumnName("IS_IMPORTED");

                entity.Property(e => e.OldTinBusiName)
                    .HasColumnName("OLD_TIN_BUSI_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.OldTinBusiTin)
                    .HasColumnName("OLD_TIN_BUSI_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.RjscBusiName)
                    .HasColumnName("RJSC_BUSI_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.RjscBusiTin)
                    .HasColumnName("RJSC_BUSI_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<NbrTinBusinessInfo>(entity =>
            {
                entity.HasKey(e => e.BusiInfoNo);

                entity.ToTable("NBR_TIN_BUSINESS_INFO");

                entity.HasIndex(e => e.TinInfoNo)
                    .HasName("IX_NBR_TIN_BUSINESS_INFO_GET");

                entity.Property(e => e.BusiInfoNo).HasColumnName("BUSI_INFO_NO");

                entity.Property(e => e.BusiName)
                    .HasColumnName("BUSI_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.BusiTin)
                    .HasColumnName("BUSI_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.BusiTypeNo).HasColumnName("BUSI_TYPE_NO");

                entity.Property(e => e.CountryName)
                    .HasColumnName("COUNTRY_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.EcDob)
                    .HasColumnName("EC_DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.EcName)
                    .HasColumnName("EC_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.EcNid)
                    .HasColumnName("EC_NID")
                    .HasMaxLength(100);

                entity.Property(e => e.EcTitle)
                    .HasColumnName("EC_TITLE")
                    .HasMaxLength(500);

                entity.Property(e => e.InsertTime)
                    .HasColumnName("INSERT_TIME")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsImported)
                    .HasColumnName("IS_IMPORTED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OldTinBusiName)
                    .HasColumnName("OLD_TIN_BUSI_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.OldTinBusiTin)
                    .HasColumnName("OLD_TIN_BUSI_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.RjscBusiName)
                    .HasColumnName("RJSC_BUSI_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.RjscBusiTin)
                    .HasColumnName("RJSC_BUSI_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.RjscRandNum)
                    .HasColumnName("RJSC_RAND_NUM")
                    .HasMaxLength(20);

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.BusiTypeNoNavigation)
                    .WithMany(p => p.NbrTinBusinessInfo)
                    .HasForeignKey(d => d.BusiTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_TIN_BUSINESS_INFO_GEN_BUSINESS_TYPE");

                entity.HasOne(d => d.TinInfoNoNavigation)
                    .WithMany(p => p.NbrTinBusinessInfo)
                    .HasForeignKey(d => d.TinInfoNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_TIN_BUSINESS_INFO_NBR_TIN_INFO");
            });

            modelBuilder.Entity<NbrTinBusiReq>(entity =>
            {
                entity.HasKey(e => e.BusiReqNo);

                entity.ToTable("NBR_TIN_BUSI_REQ");

                entity.Property(e => e.BusiReqNo).HasColumnName("BUSI_REQ_NO");

                entity.Property(e => e.ApproveLogonNo).HasColumnName("APPROVE_LOGON_NO");

                entity.Property(e => e.ApproveStatusNum).HasColumnName("APPROVE_STATUS_NUM");

                entity.Property(e => e.ApproveTime)
                    .HasColumnName("APPROVE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApproveUserNo).HasColumnName("APPROVE_USER_NO");

                entity.Property(e => e.BusiName)
                    .HasColumnName("BUSI_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.BusiTin)
                    .HasColumnName("BUSI_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.BusiTypeNo).HasColumnName("BUSI_TYPE_NO");

                entity.Property(e => e.CountryName)
                    .HasColumnName("COUNTRY_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.EcDob)
                    .HasColumnName("EC_DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.EcName)
                    .HasColumnName("EC_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.EcNid)
                    .HasColumnName("EC_NID")
                    .HasMaxLength(100);

                entity.Property(e => e.EcTitle)
                    .HasColumnName("EC_TITLE")
                    .HasMaxLength(500);

                entity.Property(e => e.InsertTime)
                    .HasColumnName("INSERT_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsImported).HasColumnName("IS_IMPORTED");

                entity.Property(e => e.OldTinBusiName)
                    .HasColumnName("OLD_TIN_BUSI_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.OldTinBusiTin)
                    .HasColumnName("OLD_TIN_BUSI_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.ReqLogonNo).HasColumnName("REQ_LOGON_NO");

                entity.Property(e => e.ReqNo).HasColumnName("REQ_NO");

                entity.Property(e => e.ReqTime)
                    .HasColumnName("REQ_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReqUserNo).HasColumnName("REQ_USER_NO");

                entity.Property(e => e.RjscBusiName)
                    .HasColumnName("RJSC_BUSI_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.RjscBusiTin)
                    .HasColumnName("RJSC_BUSI_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.ReqNoNavigation)
                    .WithMany(p => p.NbrTinBusiReq)
                    .HasForeignKey(d => d.ReqNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_TIN_BUSI_REQ_NBR_TIN_STATUS_REQ");
            });

            modelBuilder.Entity<NbrTinInfo>(entity =>
            {
                entity.HasKey(e => e.TinInfoNo);

                entity.ToTable("NBR_TIN_INFO");

                entity.HasIndex(e => e.ContactTelephoneSub)
                    .HasName("IDX_NBR_TIN_INFO_TEL_SEARCH_GET");

                entity.HasIndex(e => e.IncorpNumber)
                    .HasName("IDX_NBR_TIN_INFO_INCORP_NUMBER")
                    .IsUnique()
                    .HasFilter("([INCORP_NUMBER] IS NOT NULL)");

                entity.HasIndex(e => e.NewTin)
                    .HasName("IDX_NBR_TIN_INFO_NEW_TIN")
                    .IsUnique()
                    .HasFilter("([NEW_TIN] IS NOT NULL)");

                entity.HasIndex(e => e.Nid)
                    .HasName("IDX_NBR_TIN_INFO_NID")
                    .IsUnique()
                    .HasFilter("([NID] IS NOT NULL)");

                entity.HasIndex(e => e.Nid13)
                    .HasName("IDX_NBR_TIN_INFO_NID_13");

                entity.HasIndex(e => e.OldTin)
                    .HasName("IDX_NBR_TIN_INFO_OLD_TIN")
                    .IsUnique()
                    .HasFilter("([OLD_TIN] IS NOT NULL)");

                entity.HasIndex(e => e.PassportNumber)
                    .HasName("IDX_NBR_TIN_INFO_PASSPORT_TOKEN_NULL")
                    .IsUnique()
                    .HasFilter("([PASSPORT_NUMBER] IS NOT NULL AND [IS_TOKEN_APPROVED] IS NULL)");

                entity.HasIndex(e => e.SmartId)
                    .HasName("IDX_NBR_TIN_INFO_SMART_ID")
                    .IsUnique()
                    .HasFilter("([SMART_ID] IS NOT NULL)");

                entity.HasIndex(e => e.TokenIssued)
                    .HasName("IDX_NBR_TIN_INFO_TOKEN")
                    .IsUnique()
                    .HasFilter("([TOKEN_ISSUED] IS NOT NULL)");

                entity.HasIndex(e => e.UserNo)
                    .HasName("IDX_NBR_TIN_INFO_USER_NO");

                entity.HasIndex(e => new { e.IsTokenApproved, e.RegTypeNo })
                    .HasName("IX_NBR_TIN_INFO_SEARCH");

                entity.HasIndex(e => new { e.Nid, e.IsDup })
                    .HasName("IDX_NBR_TIN_INFO_NID_DUP")
                    .IsUnique()
                    .HasFilter("([NID] IS NOT NULL)");

                entity.HasIndex(e => new { e.NewTin, e.AssesName, e.IsInvalid })
                    .HasName("IDX_NBR_TIN_INFO_GET");

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");

                entity.Property(e => e.ApproveLogonHisNo).HasColumnName("APPROVE_LOGON_HIS_NO");

                entity.Property(e => e.ApproveRejectComments)
                    .HasColumnName("APPROVE_REJECT_COMMENTS")
                    .HasMaxLength(500);

                entity.Property(e => e.ApproveRejectReasonNo).HasColumnName("APPROVE_REJECT_REASON_NO");

                entity.Property(e => e.ApproveUserNo).HasColumnName("APPROVE_USER_NO");

                entity.Property(e => e.AssesName)
                    .IsRequired()
                    .HasColumnName("ASSES_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.BloodGroupNo).HasColumnName("BLOOD_GROUP_NO");

                entity.Property(e => e.BoiDate)
                    .HasColumnName("BOI_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.BoiNumber)
                    .HasColumnName("BOI_NUMBER")
                    .HasMaxLength(100);

                entity.Property(e => e.CertificateUpdateDate)
                    .HasColumnName("CERTIFICATE_UPDATE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CircleNo).HasColumnName("CIRCLE_NO");

                entity.Property(e => e.Comments)
                    .HasColumnName("COMMENTS")
                    .HasMaxLength(500);

                entity.Property(e => e.ContactEmailAddr)
                    .HasColumnName("CONTACT_EMAIL_ADDR")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactFax)
                    .HasColumnName("CONTACT_FAX")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactTelephone)
                    .HasColumnName("CONTACT_TELEPHONE")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactTelephoneSub)
                    .HasColumnName("CONTACT_TELEPHONE_SUB")
                    .HasMaxLength(9)
                    .HasComputedColumnSql("(right([CONTACT_TELEPHONE],(9)))");

                entity.Property(e => e.ContactUpdateReason)
                    .HasColumnName("CONTACT_UPDATE_REASON")
                    .HasMaxLength(500);

                entity.Property(e => e.ContactUpdateReasonNo).HasColumnName("CONTACT_UPDATE_REASON_NO");

                entity.Property(e => e.CountNo).HasColumnName("COUNT_NO");

                entity.Property(e => e.DesigNo).HasColumnName("DESIG_NO");

                entity.Property(e => e.DistNo).HasColumnName("DIST_NO");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.EcReconTry).HasColumnName("EC_RECON_TRY");

                entity.Property(e => e.FathName)
                    .HasColumnName("FATH_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.GenderNum).HasColumnName("GENDER_NUM");

                entity.Property(e => e.GuardName)
                    .HasColumnName("GUARD_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.GuardNid)
                    .HasColumnName("GUARD_NID")
                    .HasMaxLength(100);

                entity.Property(e => e.GuardNidBfathName)
                    .HasColumnName("GUARD_NID_BFATH_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.GuardNidBmothName)
                    .HasColumnName("GUARD_NID_BMOTH_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.GuardNidBname)
                    .HasColumnName("GUARD_NID_BNAME")
                    .HasMaxLength(500);

                entity.Property(e => e.GuardNidBperAddr)
                    .HasColumnName("GUARD_NID_BPER_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.GuardNidDob)
                    .HasColumnName("GUARD_NID_DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.GuardNidName)
                    .HasColumnName("GUARD_NID_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.GuardNidTitle)
                    .HasColumnName("GUARD_NID_TITLE")
                    .HasMaxLength(500);

                entity.Property(e => e.GuardTin)
                    .HasColumnName("GUARD_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.GuardianPpIssueDate)
                    .HasColumnName("GUARDIAN_PP_ISSUE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.GuardianPpNumber)
                    .HasColumnName("GUARDIAN_PP_NUMBER")
                    .HasMaxLength(100);

                entity.Property(e => e.GuardianVisaDate)
                    .HasColumnName("GUARDIAN_VISA_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.GuardianVisaNumber)
                    .HasColumnName("GUARDIAN_VISA_NUMBER")
                    .HasMaxLength(500);

                entity.Property(e => e.IncorpDate)
                    .HasColumnName("INCORP_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.IncorpNumber)
                    .HasColumnName("INCORP_NUMBER")
                    .HasMaxLength(100);

                entity.Property(e => e.InsertTime)
                    .HasColumnName("INSERT_TIME")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsAdminInput)
                    .HasColumnName("IS_ADMIN_INPUT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsAutoJuri)
                    .HasColumnName("IS_AUTO_JURI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCompleteProfile)
                    .HasColumnName("IS_COMPLETE_PROFILE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDup).HasColumnName("IS_DUP");

                entity.Property(e => e.IsInvalid).HasColumnName("IS_INVALID");

                entity.Property(e => e.IsLocal)
                    .HasColumnName("IS_LOCAL")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsOldTin).HasColumnName("IS_OLD_TIN");

                entity.Property(e => e.IsSmartApply)
                    .HasColumnName("IS_SMART_APPLY")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsStatusChange).HasColumnName("IS_STATUS_CHANGE");

                entity.Property(e => e.IsTemp)
                    .HasColumnName("IS_TEMP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsTokenApproved).HasColumnName("IS_TOKEN_APPROVED");

                entity.Property(e => e.IsTokenVerified)
                    .HasColumnName("IS_TOKEN_VERIFIED")
                    //.HasDefaultValueSql("((0))")
                    ;

                entity.Property(e => e.IsUserChange).HasColumnName("IS_USER_CHANGE");

                entity.Property(e => e.JuriListName)
                    .HasColumnName("JURI_LIST_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.JuriSelectListNo).HasColumnName("JURI_SELECT_LIST_NO");

                entity.Property(e => e.JuriSelectTypeNo).HasColumnName("JURI_SELECT_TYPE_NO");

                entity.Property(e => e.JuriSubListName)
                    .HasColumnName("JURI_SUB_LIST_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.JuriSubListNo).HasColumnName("JURI_SUB_LIST_NO");

                entity.Property(e => e.JuriTypeNo).HasColumnName("JURI_TYPE_NO");

                entity.Property(e => e.LogonHisNo).HasColumnName("LOGON_HIS_NO");

                entity.Property(e => e.MothName)
                    .HasColumnName("MOTH_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NewTin)
                    .HasColumnName("NEW_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.Nid)
                    .HasColumnName("NID")
                    .HasMaxLength(100);

                entity.Property(e => e.Nid13)
                    .HasColumnName("NID_13")
                    .HasMaxLength(13)
                    .HasComputedColumnSql("(right([NID],(13)))");

                entity.Property(e => e.NidBfathName)
                    .HasColumnName("NID_BFATH_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NidBmothName)
                    .HasColumnName("NID_BMOTH_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NidBname)
                    .HasColumnName("NID_BNAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NidBperAddr)
                    .HasColumnName("NID_BPER_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.NidBpreAddr)
                    .HasColumnName("NID_BPRE_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.NidBspouseName)
                    .HasColumnName("NID_BSPOUSE_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NidDob)
                    .HasColumnName("NID_DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.NidName)
                    .HasColumnName("NID_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NidTitle)
                    .HasColumnName("NID_TITLE")
                    .HasMaxLength(500);

                entity.Property(e => e.OldTin)
                    .HasColumnName("OLD_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.PassportExpDate)
                    .HasColumnName("PASSPORT_EXP_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PassportIssueDate)
                    .HasColumnName("PASSPORT_ISSUE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PassportNumber)
                    .HasColumnName("PASSPORT_NUMBER")
                    .HasMaxLength(100);

                entity.Property(e => e.PassportTypeNum).HasColumnName("PASSPORT_TYPE_NUM");

                entity.Property(e => e.PermitAuthorityId)
                    .HasColumnName("PERMIT_AUTHORITY_ID")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.PrevRegTypeNo).HasColumnName("PREV_REG_TYPE_NO");

                entity.Property(e => e.PrevUserNo).HasColumnName("PREV_USER_NO");

                entity.Property(e => e.RefTinInfoNo).HasColumnName("REF_TIN_INFO_NO");

                entity.Property(e => e.RegJuriTypeNo).HasColumnName("REG_JURI_TYPE_NO");

                entity.Property(e => e.RegTypeNo).HasColumnName("REG_TYPE_NO");

                entity.Property(e => e.RelevantDob)
                    .HasColumnName("RELEVANT_DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.RelevantName)
                    .HasColumnName("RELEVANT_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.RelevantNid)
                    .HasColumnName("RELEVANT_NID")
                    .HasMaxLength(100);

                entity.Property(e => e.RelevantTin)
                    .HasColumnName("RELEVANT_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.RjscAddr)
                    .HasColumnName("RJSC_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.RjscName)
                    .HasColumnName("RJSC_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.RjscToken)
                    .HasColumnName("RJSC_TOKEN")
                    .HasMaxLength(20);

                entity.Property(e => e.SmartId)
                    .HasColumnName("SMART_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.SpouseName)
                    .HasColumnName("SPOUSE_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.TempTin)
                    .HasColumnName("TEMP_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.TinDate)
                    .HasColumnName("TIN_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(500);

                entity.Property(e => e.TokenApproveDate)
                    .HasColumnName("TOKEN_APPROVE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.TokenComments)
                    .HasColumnName("TOKEN_COMMENTS")
                    .HasMaxLength(500);

                entity.Property(e => e.TokenDate)
                    .HasColumnName("TOKEN_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.TokenExpiryDate)
                    .HasColumnName("TOKEN_EXPIRY_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.TokenIssued)
                    .HasColumnName("TOKEN_ISSUED")
                    .HasMaxLength(100);

                entity.Property(e => e.TokenLogonHisNo).HasColumnName("TOKEN_LOGON_HIS_NO");

                entity.Property(e => e.TokenRejectComments)
                    .HasColumnName("TOKEN_REJECT_COMMENTS")
                    .HasMaxLength(500);

                entity.Property(e => e.TokenRejectReasonNo).HasColumnName("TOKEN_REJECT_REASON_NO");

                entity.Property(e => e.TokenUserNo).HasColumnName("TOKEN_USER_NO");

                entity.Property(e => e.TokenVerifyDate)
                    .HasColumnName("TOKEN_VERIFY_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateLogonHisNo).HasColumnName("UPDATE_LOGON_HIS_NO");

                entity.Property(e => e.UpdateReason)
                    .HasColumnName("UPDATE_REASON")
                    .HasMaxLength(1000);

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserNo).HasColumnName("UPDATE_USER_NO");

                entity.Property(e => e.UserNo).HasColumnName("USER_NO");

                entity.Property(e => e.VerifyLogonHisNo).HasColumnName("VERIFY_LOGON_HIS_NO");

                entity.Property(e => e.VerifyUserNo).HasColumnName("VERIFY_USER_NO");

                entity.Property(e => e.VisaDate)
                    .HasColumnName("VISA_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.VisaNumber)
                    .HasColumnName("VISA_NUMBER")
                    .HasMaxLength(500);

                entity.HasOne(d => d.BloodGroupNoNavigation)
                    .WithMany(p => p.NbrTinInfo)
                    .HasForeignKey(d => d.BloodGroupNo)
                    .HasConstraintName("FK_NBR_TIN_INFO_GEN_BLOOD_GROUP");

                entity.HasOne(d => d.CircleNoNavigation)
                    .WithMany(p => p.NbrTinInfo)
                    .HasForeignKey(d => d.CircleNo)
                    .HasConstraintName("FK_NBR_TIN_INFO_GEN_CIRCLE_INFO");

                entity.HasOne(d => d.ContactUpdateReasonNoNavigation)
                    .WithMany(p => p.NbrTinInfo)
                    .HasForeignKey(d => d.ContactUpdateReasonNo)
                    .HasConstraintName("FK_NBR_TIN_INFO_GEN_CONTACT_UPDATE_REASON");

                entity.HasOne(d => d.CountNoNavigation)
                    .WithMany(p => p.NbrTinInfo)
                    .HasForeignKey(d => d.CountNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_TIN_INFO_GEN_COUNTRY");

                entity.HasOne(d => d.DesigNoNavigation)
                    .WithMany(p => p.NbrTinInfo)
                    .HasForeignKey(d => d.DesigNo)
                    .HasConstraintName("FK_NBR_TIN_INFO_GEN_DESIG_LIST");

                entity.HasOne(d => d.DistNoNavigation)
                    .WithMany(p => p.NbrTinInfo)
                    .HasForeignKey(d => d.DistNo)
                    .HasConstraintName("FK_NBR_TIN_INFO_GEN_DISTRICT");

                entity.HasOne(d => d.JuriSelectListNoNavigation)
                    .WithMany(p => p.NbrTinInfo)
                    .HasForeignKey(d => d.JuriSelectListNo)
                    .HasConstraintName("FK_NBR_TIN_INFO_GEN_JURI_SELECT_LIST");

                entity.HasOne(d => d.JuriSelectTypeNoNavigation)
                    .WithMany(p => p.NbrTinInfo)
                    .HasForeignKey(d => d.JuriSelectTypeNo)
                    .HasConstraintName("FK_NBR_TIN_INFO_GEN_JURI_SELECT_TYPE");

                entity.HasOne(d => d.JuriSubListNoNavigation)
                    .WithMany(p => p.NbrTinInfo)
                    .HasForeignKey(d => d.JuriSubListNo)
                    .HasConstraintName("FK_NBR_TIN_INFO_GEN_JURI_SUB_LIST");

                entity.HasOne(d => d.JuriTypeNoNavigation)
                    .WithMany(p => p.NbrTinInfo)
                    .HasForeignKey(d => d.JuriTypeNo)
                    .HasConstraintName("FK_NBR_TIN_INFO_GEN_JURISDICTION_TYPE");

                entity.HasOne(d => d.PermitAuthority)
                    .WithMany(p => p.NbrTinInfo)
                    .HasForeignKey(d => d.PermitAuthorityId)
                    .HasConstraintName("FK_GEN_WORK_PERMIT_AUTHORITY_LIST");

                entity.HasOne(d => d.RegJuriTypeNoNavigation)
                    .WithMany(p => p.NbrTinInfo)
                    .HasForeignKey(d => d.RegJuriTypeNo)
                    .HasConstraintName("FK_NBR_TIN_INFO_GEN_REG_JURI_TYPE");

                entity.HasOne(d => d.RegTypeNoNavigation)
                    .WithMany(p => p.NbrTinInfo)
                    .HasForeignKey(d => d.RegTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_TIN_INFO_GEN_REG_TYPE");

                entity.HasOne(d => d.TokenRejectReasonNoNavigation)
                    .WithMany(p => p.NbrTinInfo)
                    .HasForeignKey(d => d.TokenRejectReasonNo)
                    .HasConstraintName("FK_NBR_TIN_INFO_GEN_TOKEN_REJECT_REASON");

                entity.HasOne(d => d.UserNoNavigation)
                    .WithMany(p => p.NbrTinInfo)
                    .HasForeignKey(d => d.UserNo)
                    .HasConstraintName("FK_NBR_TIN_INFO_NBR_USERS");
            });

            modelBuilder.Entity<NbrTinInfoHis>(entity =>
            {
                entity.HasKey(e => e.InfoHisNo);

                entity.ToTable("NBR_TIN_INFO_HIS");

                entity.Property(e => e.InfoHisNo).HasColumnName("INFO_HIS_NO");

                entity.Property(e => e.AssesName)
                    .IsRequired()
                    .HasColumnName("ASSES_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.BloodGroupNo).HasColumnName("BLOOD_GROUP_NO");

                entity.Property(e => e.BoiDate)
                    .HasColumnName("BOI_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.BoiNumber)
                    .HasColumnName("BOI_NUMBER")
                    .HasMaxLength(100);

                entity.Property(e => e.CircleNo).HasColumnName("CIRCLE_NO");

                entity.Property(e => e.Comments)
                    .HasColumnName("COMMENTS")
                    .HasMaxLength(500);

                entity.Property(e => e.ContactEmailAddr)
                    .HasColumnName("CONTACT_EMAIL_ADDR")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactFax)
                    .HasColumnName("CONTACT_FAX")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactTelephone)
                    .HasColumnName("CONTACT_TELEPHONE")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactUpdateReason)
                    .HasColumnName("CONTACT_UPDATE_REASON")
                    .HasMaxLength(500);

                entity.Property(e => e.ContactUpdateReasonNo).HasColumnName("CONTACT_UPDATE_REASON_NO");

                entity.Property(e => e.CountNo).HasColumnName("COUNT_NO");

                entity.Property(e => e.DesigNo).HasColumnName("DESIG_NO");

                entity.Property(e => e.DistNo).HasColumnName("DIST_NO");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.FathName)
                    .HasColumnName("FATH_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.GenderNum).HasColumnName("GENDER_NUM");

                entity.Property(e => e.GuardName)
                    .HasColumnName("GUARD_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.GuardNid)
                    .HasColumnName("GUARD_NID")
                    .HasMaxLength(100);

                entity.Property(e => e.GuardNidBfathName)
                    .HasColumnName("GUARD_NID_BFATH_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.GuardNidBmothName)
                    .HasColumnName("GUARD_NID_BMOTH_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.GuardNidBname)
                    .HasColumnName("GUARD_NID_BNAME")
                    .HasMaxLength(500);

                entity.Property(e => e.GuardNidBperAddr)
                    .HasColumnName("GUARD_NID_BPER_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.GuardNidDob)
                    .HasColumnName("GUARD_NID_DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.GuardNidName)
                    .HasColumnName("GUARD_NID_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.GuardNidTitle)
                    .HasColumnName("GUARD_NID_TITLE")
                    .HasMaxLength(500);

                entity.Property(e => e.GuardTin)
                    .HasColumnName("GUARD_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.GuardianPpIssueDate)
                    .HasColumnName("GUARDIAN_PP_ISSUE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.GuardianPpNumber)
                    .HasColumnName("GUARDIAN_PP_NUMBER")
                    .HasMaxLength(100);

                entity.Property(e => e.GuardianVisaDate)
                    .HasColumnName("GUARDIAN_VISA_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.GuardianVisaNumber)
                    .HasColumnName("GUARDIAN_VISA_NUMBER")
                    .HasMaxLength(500);

                entity.Property(e => e.IncorpDate)
                    .HasColumnName("INCORP_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.IncorpNumber)
                    .HasColumnName("INCORP_NUMBER")
                    .HasMaxLength(100);

                entity.Property(e => e.InsertTime)
                    .HasColumnName("INSERT_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsAdminInput).HasColumnName("IS_ADMIN_INPUT");

                entity.Property(e => e.IsAutoJuri).HasColumnName("IS_AUTO_JURI");

                entity.Property(e => e.IsCompleteProfile).HasColumnName("IS_COMPLETE_PROFILE");

                entity.Property(e => e.IsInvalid).HasColumnName("IS_INVALID");

                entity.Property(e => e.IsLocal).HasColumnName("IS_LOCAL");

                entity.Property(e => e.IsOldTin).HasColumnName("IS_OLD_TIN");

                entity.Property(e => e.IsSmartApply)
                    .HasColumnName("IS_SMART_APPLY")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsStatusChange).HasColumnName("IS_STATUS_CHANGE");

                entity.Property(e => e.IsTemp).HasColumnName("IS_TEMP");

                entity.Property(e => e.IsTokenVerified).HasColumnName("IS_TOKEN_VERIFIED");

                entity.Property(e => e.IsUserChange).HasColumnName("IS_USER_CHANGE");

                entity.Property(e => e.JuriListName)
                    .HasColumnName("JURI_LIST_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.JuriSelectListNo).HasColumnName("JURI_SELECT_LIST_NO");

                entity.Property(e => e.JuriSelectTypeNo).HasColumnName("JURI_SELECT_TYPE_NO");

                entity.Property(e => e.JuriSubListName)
                    .HasColumnName("JURI_SUB_LIST_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.JuriSubListNo).HasColumnName("JURI_SUB_LIST_NO");

                entity.Property(e => e.JuriTypeNo).HasColumnName("JURI_TYPE_NO");

                entity.Property(e => e.LogonHisNo).HasColumnName("LOGON_HIS_NO");

                entity.Property(e => e.MothName)
                    .HasColumnName("MOTH_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NewTin)
                    .HasColumnName("NEW_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.Nid)
                    .HasColumnName("NID")
                    .HasMaxLength(100);

                entity.Property(e => e.NidBfathName)
                    .HasColumnName("NID_BFATH_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NidBmothName)
                    .HasColumnName("NID_BMOTH_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NidBname)
                    .HasColumnName("NID_BNAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NidBperAddr)
                    .HasColumnName("NID_BPER_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.NidBpreAddr)
                    .HasColumnName("NID_BPRE_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.NidBspouseName)
                    .HasColumnName("NID_BSPOUSE_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NidDob)
                    .HasColumnName("NID_DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.NidName)
                    .HasColumnName("NID_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NidTitle)
                    .HasColumnName("NID_TITLE")
                    .HasMaxLength(500);

                entity.Property(e => e.OldTin)
                    .HasColumnName("OLD_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.PassportExpDate)
                    .HasColumnName("PASSPORT_EXP_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PassportIssueDate)
                    .HasColumnName("PASSPORT_ISSUE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PassportNumber)
                    .HasColumnName("PASSPORT_NUMBER")
                    .HasMaxLength(100);

                entity.Property(e => e.PassportTypeNum).HasColumnName("PASSPORT_TYPE_NUM");

                entity.Property(e => e.PrevRegTypeNo).HasColumnName("PREV_REG_TYPE_NO");

                entity.Property(e => e.PrevUserNo).HasColumnName("PREV_USER_NO");

                entity.Property(e => e.RefTinInfoNo).HasColumnName("REF_TIN_INFO_NO");

                entity.Property(e => e.RegJuriTypeNo).HasColumnName("REG_JURI_TYPE_NO");

                entity.Property(e => e.RegTypeNo).HasColumnName("REG_TYPE_NO");

                entity.Property(e => e.RelevantDob)
                    .HasColumnName("RELEVANT_DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.RelevantName)
                    .HasColumnName("RELEVANT_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.RelevantNid)
                    .HasColumnName("RELEVANT_NID")
                    .HasMaxLength(100);

                entity.Property(e => e.RelevantTin)
                    .HasColumnName("RELEVANT_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.RjscAddr)
                    .HasColumnName("RJSC_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.RjscName)
                    .HasColumnName("RJSC_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.SmartId)
                    .HasColumnName("SMART_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.SpouseName)
                    .HasColumnName("SPOUSE_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.TempTin)
                    .HasColumnName("TEMP_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.TinDate)
                    .HasColumnName("TIN_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(500);

                entity.Property(e => e.TokenComments)
                    .HasColumnName("TOKEN_COMMENTS")
                    .HasMaxLength(500);

                entity.Property(e => e.TokenDate)
                    .HasColumnName("TOKEN_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.TokenExpiryDate)
                    .HasColumnName("TOKEN_EXPIRY_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.TokenIssued)
                    .HasColumnName("TOKEN_ISSUED")
                    .HasMaxLength(100);

                entity.Property(e => e.TokenLogonHisNo).HasColumnName("TOKEN_LOGON_HIS_NO");

                entity.Property(e => e.TokenRejectComments)
                    .HasColumnName("TOKEN_REJECT_COMMENTS")
                    .HasMaxLength(500);

                entity.Property(e => e.TokenRejectReasonNo).HasColumnName("TOKEN_REJECT_REASON_NO");

                entity.Property(e => e.TokenUserNo).HasColumnName("TOKEN_USER_NO");

                entity.Property(e => e.TokenVerifyDate)
                    .HasColumnName("TOKEN_VERIFY_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateLogonHisNo).HasColumnName("UPDATE_LOGON_HIS_NO");

                entity.Property(e => e.UpdateReason)
                    .HasColumnName("UPDATE_REASON")
                    .HasMaxLength(1000);

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserNo).HasColumnName("UPDATE_USER_NO");

                entity.Property(e => e.UserNo).HasColumnName("USER_NO");

                entity.Property(e => e.VerifyLogonHisNo).HasColumnName("VERIFY_LOGON_HIS_NO");

                entity.Property(e => e.VerifyUserNo).HasColumnName("VERIFY_USER_NO");

                entity.Property(e => e.VisaDate)
                    .HasColumnName("VISA_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.VisaNumber)
                    .HasColumnName("VISA_NUMBER")
                    .HasMaxLength(500);

                entity.HasOne(d => d.TinInfoNoNavigation)
                    .WithMany(p => p.NbrTinInfoHis)
                    .HasForeignKey(d => d.TinInfoNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_TIN_INFO_HIS_NBR_TIN_INFO");
            });

            modelBuilder.Entity<NbrTinStatusReq>(entity =>
            {
                entity.HasKey(e => e.ReqNo);

                entity.ToTable("NBR_TIN_STATUS_REQ");

                entity.HasIndex(e => e.TinInfoNo)
                    .HasName("IX_NBR_TIN_STATUS_REQ_GET")
                    .HasFilter("([APPROVE_STATUS_NUM] IS NULL)");

                entity.Property(e => e.ReqNo)
                    .HasColumnName("REQ_NO")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ApproveComments)
                    .HasColumnName("APPROVE_COMMENTS")
                    .HasMaxLength(1000);

                entity.Property(e => e.ApproveLogonNo).HasColumnName("APPROVE_LOGON_NO");

                entity.Property(e => e.ApproveStatusNum).HasColumnName("APPROVE_STATUS_NUM");

                entity.Property(e => e.ApproveTime)
                    .HasColumnName("APPROVE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApproveUserNo).HasColumnName("APPROVE_USER_NO");

                entity.Property(e => e.AssesName)
                    .IsRequired()
                    .HasColumnName("ASSES_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.AttachData).HasColumnName("ATTACH_DATA");

                entity.Property(e => e.AttachExt)
                    .HasColumnName("ATTACH_EXT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AttachName)
                    .HasColumnName("ATTACH_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.BloodGroupNo).HasColumnName("BLOOD_GROUP_NO");

                entity.Property(e => e.BoiDate)
                    .HasColumnName("BOI_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.BoiNumber)
                    .HasColumnName("BOI_NUMBER")
                    .HasMaxLength(100);

                entity.Property(e => e.CircleNo).HasColumnName("CIRCLE_NO");

                entity.Property(e => e.Comments)
                    .HasColumnName("COMMENTS")
                    .HasMaxLength(500);

                entity.Property(e => e.ContactEmailAddr)
                    .HasColumnName("CONTACT_EMAIL_ADDR")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactFax)
                    .HasColumnName("CONTACT_FAX")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactTelephone)
                    .HasColumnName("CONTACT_TELEPHONE")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactUpdateReason)
                    .HasColumnName("CONTACT_UPDATE_REASON")
                    .HasMaxLength(500);

                entity.Property(e => e.ContactUpdateReasonNo).HasColumnName("CONTACT_UPDATE_REASON_NO");

                entity.Property(e => e.CountNo).HasColumnName("COUNT_NO");

                entity.Property(e => e.DesigNo).HasColumnName("DESIG_NO");

                entity.Property(e => e.DistNo).HasColumnName("DIST_NO");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.FathName)
                    .HasColumnName("FATH_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.GenderNum).HasColumnName("GENDER_NUM");

                entity.Property(e => e.GuardName)
                    .HasColumnName("GUARD_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.GuardNid)
                    .HasColumnName("GUARD_NID")
                    .HasMaxLength(100);

                entity.Property(e => e.GuardNidBfathName)
                    .HasColumnName("GUARD_NID_BFATH_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.GuardNidBmothName)
                    .HasColumnName("GUARD_NID_BMOTH_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.GuardNidBname)
                    .HasColumnName("GUARD_NID_BNAME")
                    .HasMaxLength(500);

                entity.Property(e => e.GuardNidBperAddr)
                    .HasColumnName("GUARD_NID_BPER_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.GuardNidDob)
                    .HasColumnName("GUARD_NID_DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.GuardNidName)
                    .HasColumnName("GUARD_NID_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.GuardNidTitle)
                    .HasColumnName("GUARD_NID_TITLE")
                    .HasMaxLength(500);

                entity.Property(e => e.GuardTin)
                    .HasColumnName("GUARD_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.GuardianPpIssueDate)
                    .HasColumnName("GUARDIAN_PP_ISSUE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.GuardianPpNumber)
                    .HasColumnName("GUARDIAN_PP_NUMBER")
                    .HasMaxLength(100);

                entity.Property(e => e.GuardianVisaDate)
                    .HasColumnName("GUARDIAN_VISA_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.GuardianVisaNumber)
                    .HasColumnName("GUARDIAN_VISA_NUMBER")
                    .HasMaxLength(500);

                entity.Property(e => e.IncorpDate)
                    .HasColumnName("INCORP_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.IncorpNumber)
                    .HasColumnName("INCORP_NUMBER")
                    .HasMaxLength(100);

                entity.Property(e => e.InsertTime)
                    .HasColumnName("INSERT_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsAdminInput).HasColumnName("IS_ADMIN_INPUT");

                entity.Property(e => e.IsAutoJuri).HasColumnName("IS_AUTO_JURI");

                entity.Property(e => e.IsCompleteProfile).HasColumnName("IS_COMPLETE_PROFILE");

                entity.Property(e => e.IsImported)
                    .HasColumnName("IS_IMPORTED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsInvalid).HasColumnName("IS_INVALID");

                entity.Property(e => e.IsLocal).HasColumnName("IS_LOCAL");

                entity.Property(e => e.IsOldTin).HasColumnName("IS_OLD_TIN");

                entity.Property(e => e.IsSmartApply)
                    .HasColumnName("IS_SMART_APPLY")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsTemp).HasColumnName("IS_TEMP");

                entity.Property(e => e.IsTokenVerified).HasColumnName("IS_TOKEN_VERIFIED");

                entity.Property(e => e.JuriListName)
                    .HasColumnName("JURI_LIST_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.JuriSelectListNo).HasColumnName("JURI_SELECT_LIST_NO");

                entity.Property(e => e.JuriSelectTypeNo).HasColumnName("JURI_SELECT_TYPE_NO");

                entity.Property(e => e.JuriSubListName)
                    .HasColumnName("JURI_SUB_LIST_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.JuriSubListNo).HasColumnName("JURI_SUB_LIST_NO");

                entity.Property(e => e.JuriTypeNo).HasColumnName("JURI_TYPE_NO");

                entity.Property(e => e.LogonHisNo).HasColumnName("LOGON_HIS_NO");

                entity.Property(e => e.MothName)
                    .HasColumnName("MOTH_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NewTin)
                    .HasColumnName("NEW_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.Nid)
                    .HasColumnName("NID")
                    .HasMaxLength(100);

                entity.Property(e => e.NidBfathName)
                    .HasColumnName("NID_BFATH_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NidBmothName)
                    .HasColumnName("NID_BMOTH_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NidBname)
                    .HasColumnName("NID_BNAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NidBperAddr)
                    .HasColumnName("NID_BPER_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.NidBpreAddr)
                    .HasColumnName("NID_BPRE_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.NidBspouseName)
                    .HasColumnName("NID_BSPOUSE_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NidDob)
                    .HasColumnName("NID_DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.NidName)
                    .HasColumnName("NID_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.NidTitle)
                    .HasColumnName("NID_TITLE")
                    .HasMaxLength(500);

                entity.Property(e => e.OldTin)
                    .HasColumnName("OLD_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.PassportExpDate)
                    .HasColumnName("PASSPORT_EXP_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PassportIssueDate)
                    .HasColumnName("PASSPORT_ISSUE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PassportNumber)
                    .HasColumnName("PASSPORT_NUMBER")
                    .HasMaxLength(100);

                entity.Property(e => e.PassportTypeNum).HasColumnName("PASSPORT_TYPE_NUM");

                entity.Property(e => e.PrevRegTypeNo).HasColumnName("PREV_REG_TYPE_NO");

                entity.Property(e => e.RefTinInfoNo).HasColumnName("REF_TIN_INFO_NO");

                entity.Property(e => e.RegJuriTypeNo).HasColumnName("REG_JURI_TYPE_NO");

                entity.Property(e => e.RegTypeNo).HasColumnName("REG_TYPE_NO");

                entity.Property(e => e.RelevantDob)
                    .HasColumnName("RELEVANT_DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.RelevantName)
                    .HasColumnName("RELEVANT_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.RelevantNid)
                    .HasColumnName("RELEVANT_NID")
                    .HasMaxLength(100);

                entity.Property(e => e.RelevantTin)
                    .HasColumnName("RELEVANT_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.ReqLogonNo).HasColumnName("REQ_LOGON_NO");

                entity.Property(e => e.ReqTime)
                    .HasColumnName("REQ_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReqUserNo).HasColumnName("REQ_USER_NO");

                entity.Property(e => e.RjscAddr)
                    .HasColumnName("RJSC_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.RjscName)
                    .HasColumnName("RJSC_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.SmartId)
                    .HasColumnName("SMART_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.SpouseName)
                    .HasColumnName("SPOUSE_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.StatusReasonNo).HasColumnName("STATUS_REASON_NO");

                entity.Property(e => e.TempTin)
                    .HasColumnName("TEMP_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.TinDate)
                    .HasColumnName("TIN_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(500);

                entity.Property(e => e.TokenComments)
                    .HasColumnName("TOKEN_COMMENTS")
                    .HasMaxLength(500);

                entity.Property(e => e.TokenDate)
                    .HasColumnName("TOKEN_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.TokenExpiryDate)
                    .HasColumnName("TOKEN_EXPIRY_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.TokenIssued)
                    .HasColumnName("TOKEN_ISSUED")
                    .HasMaxLength(100);

                entity.Property(e => e.TokenLogonHisNo).HasColumnName("TOKEN_LOGON_HIS_NO");

                entity.Property(e => e.TokenRejectComments)
                    .HasColumnName("TOKEN_REJECT_COMMENTS")
                    .HasMaxLength(500);

                entity.Property(e => e.TokenRejectReasonNo).HasColumnName("TOKEN_REJECT_REASON_NO");

                entity.Property(e => e.TokenUserNo).HasColumnName("TOKEN_USER_NO");

                entity.Property(e => e.TokenVerifyDate)
                    .HasColumnName("TOKEN_VERIFY_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateLogonHisNo).HasColumnName("UPDATE_LOGON_HIS_NO");

                entity.Property(e => e.UpdateReason)
                    .HasColumnName("UPDATE_REASON")
                    .HasMaxLength(1000);

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserNo).HasColumnName("UPDATE_USER_NO");

                entity.Property(e => e.UserNo).HasColumnName("USER_NO");

                entity.Property(e => e.VerifyLogonHisNo).HasColumnName("VERIFY_LOGON_HIS_NO");

                entity.Property(e => e.VerifyUserNo).HasColumnName("VERIFY_USER_NO");

                entity.Property(e => e.VisaDate)
                    .HasColumnName("VISA_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.VisaNumber)
                    .HasColumnName("VISA_NUMBER")
                    .HasMaxLength(500);

                entity.HasOne(d => d.CountNoNavigation)
                    .WithMany(p => p.NbrTinStatusReq)
                    .HasForeignKey(d => d.CountNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_TIN_STATUS_REQ_GEN_COUNTRY");

                entity.HasOne(d => d.DesigNoNavigation)
                    .WithMany(p => p.NbrTinStatusReq)
                    .HasForeignKey(d => d.DesigNo)
                    .HasConstraintName("FK_NBR_TIN_STATUS_REQ_GEN_DESIG_LIST");

                entity.HasOne(d => d.RegTypeNoNavigation)
                    .WithMany(p => p.NbrTinStatusReq)
                    .HasForeignKey(d => d.RegTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_TIN_STATUS_REQ_GEN_REG_TYPE");

                entity.HasOne(d => d.ReqNoNavigation)
                    .WithOne(p => p.InverseReqNoNavigation)
                    .HasForeignKey<NbrTinStatusReq>(d => d.ReqNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_TIN_STATUS_REQ_NBR_TIN_STATUS_REQ");

                entity.HasOne(d => d.StatusReasonNoNavigation)
                    .WithMany(p => p.NbrTinStatusReq)
                    .HasForeignKey(d => d.StatusReasonNo)
                    .HasConstraintName("FK_NBR_TIN_STATUS_REQ_GEN_STATUS_REASON");

                entity.HasOne(d => d.TinInfoNoNavigation)
                    .WithMany(p => p.NbrTinStatusReq)
                    .HasForeignKey(d => d.TinInfoNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_TIN_STATUS_REQ_NBR_TIN_INFO");
            });

            modelBuilder.Entity<NbrTinUpload>(entity =>
            {
                entity.HasKey(e => e.UploadNo);

                entity.ToTable("NBR_TIN_UPLOAD");

                entity.Property(e => e.UploadNo).HasColumnName("UPLOAD_NO");

                entity.Property(e => e.InsertTime)
                    .HasColumnName("INSERT_TIME")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsImported)
                    .HasColumnName("IS_IMPORTED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");

                entity.Property(e => e.UpdateLogonNo).HasColumnName("UPDATE_LOGON_NO");

                entity.Property(e => e.UpdateReason)
                    .HasColumnName("UPDATE_REASON")
                    .HasMaxLength(2000);

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserNo).HasColumnName("UPDATE_USER_NO");

                entity.Property(e => e.UploadData).HasColumnName("UPLOAD_DATA");

                entity.Property(e => e.UploadExt)
                    .IsRequired()
                    .HasColumnName("UPLOAD_EXT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UploadName)
                    .IsRequired()
                    .HasColumnName("UPLOAD_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.UploadTypeNo).HasColumnName("UPLOAD_TYPE_NO");

                entity.HasOne(d => d.TinInfoNoNavigation)
                    .WithMany(p => p.NbrTinUpload)
                    .HasForeignKey(d => d.TinInfoNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_TIN_UPLOAD_NBR_TIN_INFO");

                entity.HasOne(d => d.UploadTypeNoNavigation)
                    .WithMany(p => p.NbrTinUpload)
                    .HasForeignKey(d => d.UploadTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_TIN_UPLOAD_GEN_UPLOAD_TYPE");
            });

            modelBuilder.Entity<NbrTinVerify>(entity =>
            {
                entity.HasKey(e => e.VerifyNo);

                entity.ToTable("NBR_TIN_VERIFY");

                entity.Property(e => e.VerifyNo).HasColumnName("VERIFY_NO");

                entity.Property(e => e.Etin)
                    .IsRequired()
                    .HasColumnName("ETIN")
                    .HasMaxLength(100);

                entity.Property(e => e.IsValid).HasColumnName("IS_VALID");

                entity.Property(e => e.Purpose)
                    .HasColumnName("PURPOSE")
                    .HasMaxLength(1000);

                entity.Property(e => e.TaxPayerName)
                    .HasColumnName("TAX_PAYER_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.VerifyTime)
                    .HasColumnName("VERIFY_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.VerifyUserLogonHisNo).HasColumnName("VERIFY_USER_LOGON_HIS_NO");

                entity.Property(e => e.VerifyUserNo).HasColumnName("VERIFY_USER_NO");
            });

            modelBuilder.Entity<NbrTokenHistory>(entity =>
            {
                entity.HasKey(e => e.TokenHisNo);

                entity.ToTable("NBR_TOKEN_HISTORY");

                entity.Property(e => e.TokenHisNo).HasColumnName("TOKEN_HIS_NO");

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");

                entity.Property(e => e.TokenComments)
                    .HasColumnName("TOKEN_COMMENTS")
                    .HasMaxLength(500);

                entity.Property(e => e.TokenDate)
                    .HasColumnName("TOKEN_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.TokenExpiryDate)
                    .HasColumnName("TOKEN_EXPIRY_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.TokenIssued)
                    .HasColumnName("TOKEN_ISSUED")
                    .HasMaxLength(100);

                entity.Property(e => e.TokenLogonHisNo).HasColumnName("TOKEN_LOGON_HIS_NO");

                entity.Property(e => e.TokenUserNo).HasColumnName("TOKEN_USER_NO");

                entity.HasOne(d => d.TinInfoNoNavigation)
                    .WithMany(p => p.NbrTokenHistory)
                    .HasForeignKey(d => d.TinInfoNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_TOKEN_HISTORY_NBR_TIN_INFO");
            });

            modelBuilder.Entity<NbrUserAttachment>(entity =>
            {
                entity.HasKey(e => e.AttachNo);

                entity.ToTable("NBR_USER_ATTACHMENT");

                entity.Property(e => e.AttachNo).HasColumnName("ATTACH_NO");

                entity.Property(e => e.AttachData)
                    .IsRequired()
                    .HasColumnName("ATTACH_DATA");

                entity.Property(e => e.AttachExt)
                    .IsRequired()
                    .HasColumnName("ATTACH_EXT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AttachName)
                    .IsRequired()
                    .HasColumnName("ATTACH_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.AttachTypeNo).HasColumnName("ATTACH_TYPE_NO");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasColumnName("DISPLAY_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.InsertLogonNo).HasColumnName("INSERT_LOGON_NO");

                entity.Property(e => e.InsertTime)
                    .HasColumnName("INSERT_TIME")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUserNo).HasColumnName("INSERT_USER_NO");

                entity.Property(e => e.UserNo).HasColumnName("USER_NO");

                entity.HasOne(d => d.AttachTypeNoNavigation)
                    .WithMany(p => p.NbrUserAttachment)
                    .HasForeignKey(d => d.AttachTypeNo)
                    .HasConstraintName("FK_NBR_USER_ATTACHMENT_GEN_ATTACH_TYPE");

                entity.HasOne(d => d.UserNoNavigation)
                    .WithMany(p => p.NbrUserAttachment)
                    .HasForeignKey(d => d.UserNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_USER_ATTACHMENT_NBR_USERS");
            });

            modelBuilder.Entity<NbrUserAttachmentHis>(entity =>
            {
                entity.HasKey(e => e.AttachHisNo);

                entity.ToTable("NBR_USER_ATTACHMENT_HIS");

                entity.Property(e => e.AttachHisNo).HasColumnName("ATTACH_HIS_NO");

                entity.Property(e => e.ActionLogonNo).HasColumnName("ACTION_LOGON_NO");

                entity.Property(e => e.ActionName)
                    .HasColumnName("ACTION_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActionTime)
                    .HasColumnName("ACTION_TIME")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ActionUserNo).HasColumnName("ACTION_USER_NO");

                entity.Property(e => e.AttachData)
                    .IsRequired()
                    .HasColumnName("ATTACH_DATA");

                entity.Property(e => e.AttachExt)
                    .IsRequired()
                    .HasColumnName("ATTACH_EXT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AttachName)
                    .IsRequired()
                    .HasColumnName("ATTACH_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.AttachNo).HasColumnName("ATTACH_NO");

                entity.Property(e => e.AttachTypeNo).HasColumnName("ATTACH_TYPE_NO");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasColumnName("DISPLAY_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.InsertLogonNo).HasColumnName("INSERT_LOGON_NO");

                entity.Property(e => e.InsertTime)
                    .HasColumnName("INSERT_TIME")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUserNo).HasColumnName("INSERT_USER_NO");

                entity.Property(e => e.UserNo).HasColumnName("USER_NO");
            });

            modelBuilder.Entity<NbrUserHistory>(entity =>
            {
                entity.HasKey(e => e.UserHisNo);

                entity.ToTable("NBR_USER_HISTORY");

                entity.Property(e => e.UserHisNo).HasColumnName("USER_HIS_NO");

                entity.Property(e => e.AdmDepartment)
                    .HasColumnName("ADM_DEPARTMENT")
                    .HasMaxLength(100);

                entity.Property(e => e.AdmDesignation)
                    .HasColumnName("ADM_DESIGNATION")
                    .HasMaxLength(100);

                entity.Property(e => e.AdmFullName)
                    .HasColumnName("ADM_FULL_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.AdmOrganization)
                    .HasColumnName("ADM_ORGANIZATION")
                    .HasMaxLength(500);

                entity.Property(e => e.UpdateLogonHisNo).HasColumnName("UPDATE_LOGON_HIS_NO");

                entity.Property(e => e.UpdateReason)
                    .HasColumnName("UPDATE_REASON")
                    .HasMaxLength(500);

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserNo).HasColumnName("UPDATE_USER_NO");

                entity.Property(e => e.UserNo).HasColumnName("USER_NO");

                entity.HasOne(d => d.UserNoNavigation)
                    .WithMany(p => p.NbrUserHistory)
                    .HasForeignKey(d => d.UserNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_USER_HISTORY_NBR_USERS");
            });

            modelBuilder.Entity<NbrUserLogonHis>(entity =>
            {
                entity.HasKey(e => e.LogonHisNo);

                entity.ToTable("NBR_USER_LOGON_HIS");

                entity.HasIndex(e => e.LogonHisNo)
                    .HasName("IX_NBR_USER_LOGON_HIS_GET");

                entity.Property(e => e.LogonHisNo).HasColumnName("LOGON_HIS_NO");

                entity.Property(e => e.InTime)
                    .HasColumnName("IN_TIME")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IpAddr)
                    .HasColumnName("IP_ADDR")
                    .HasMaxLength(100);

                entity.Property(e => e.OutTime)
                    .HasColumnName("OUT_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.SessId)
                    .IsRequired()
                    .HasColumnName("SESS_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.UserNo).HasColumnName("USER_NO");

                entity.HasOne(d => d.UserNoNavigation)
                    .WithMany(p => p.NbrUserLogonHis)
                    .HasForeignKey(d => d.UserNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_USER_LOGON_HIS_NBR_USERS");
            });

            modelBuilder.Entity<NbrUserPhotos>(entity =>
            {
                entity.HasKey(e => e.UserPhotoNo);

                entity.ToTable("NBR_USER_PHOTOS");

                entity.Property(e => e.UserPhotoNo).HasColumnName("USER_PHOTO_NO");

                entity.Property(e => e.AttachData)
                    .IsRequired()
                    .HasColumnName("ATTACH_DATA");

                entity.Property(e => e.AttachExt)
                    .IsRequired()
                    .HasColumnName("ATTACH_EXT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AttachName)
                    .IsRequired()
                    .HasColumnName("ATTACH_NAME")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.AttachTypeNo).HasColumnName("ATTACH_TYPE_NO");

                entity.Property(e => e.UserNo).HasColumnName("USER_NO");

                entity.HasOne(d => d.AttachTypeNoNavigation)
                    .WithMany(p => p.NbrUserPhotos)
                    .HasForeignKey(d => d.AttachTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_USER_PHOTOS_GEN_ATTACH_TYPE");

                entity.HasOne(d => d.UserNoNavigation)
                    .WithMany(p => p.NbrUserPhotos)
                    .HasForeignKey(d => d.UserNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_USER_PHOTOS_NBR_USERS");
            });

            modelBuilder.Entity<NbrUsers>(entity =>
            {
                entity.HasKey(e => e.UserNo);

                entity.ToTable("NBR_USERS");

                entity.HasIndex(e => e.LogonName)
                    .HasName("IX_NBR_USERS")
                    .IsUnique();

                entity.HasIndex(e => e.Mobile)
                    .HasName("IDX_NBR_USERS_MOBILE")
                    .IsUnique()
                    .HasFilter("([MOBILE] IS NOT NULL)");

                entity.HasIndex(e => e.MobileSub)
                    .HasName("IDX_NBR_USERS_MOBILE_SUB");

                entity.HasIndex(e => new { e.MobPass, e.UserTypeNo })
                    .HasName("IX_NBR_USERS_GET_BY_MOBPASS_AND_TYPE");

                entity.Property(e => e.UserNo).HasColumnName("USER_NO");

                entity.Property(e => e.AdmDepartment)
                    .HasColumnName("ADM_DEPARTMENT")
                    .HasMaxLength(100);

                entity.Property(e => e.AdmDesignation)
                    .HasColumnName("ADM_DESIGNATION")
                    .HasMaxLength(100);

                entity.Property(e => e.AdmFullName)
                    .HasColumnName("ADM_FULL_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.AdmOrganization)
                    .HasColumnName("ADM_ORGANIZATION")
                    .HasMaxLength(500);

                entity.Property(e => e.ApplicationQty)
                    .HasColumnName("APPLICATION_QTY")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CancelLogonNo).HasColumnName("CANCEL_LOGON_NO");

                entity.Property(e => e.CancelTime)
                    .HasColumnName("CANCEL_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CancelUserNo).HasColumnName("CANCEL_USER_NO");

                entity.Property(e => e.CircleNo).HasColumnName("CIRCLE_NO");

                entity.Property(e => e.ClaimUserNo).HasColumnName("CLAIM_USER_NO");

                entity.Property(e => e.CreateLogonHisNo).HasColumnName("CREATE_LOGON_HIS_NO");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("CREATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserNo).HasColumnName("CREATE_USER_NO");

                entity.Property(e => e.EmailActivateCode)
                    .HasColumnName("EMAIL_ACTIVATE_CODE")
                    .HasMaxLength(100);

                entity.Property(e => e.EmailActivateTime)
                    .HasColumnName("EMAIL_ACTIVATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmailActiveIpAddr)
                    .HasColumnName("EMAIL_ACTIVE_IP_ADDR")
                    .HasMaxLength(100);

                entity.Property(e => e.EmailAddr)
                    .HasColumnName("EMAIL_ADDR")
                    .HasMaxLength(100);

                entity.Property(e => e.FacCentName)
                    .HasColumnName("FAC_CENT_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.FacCentNo).HasColumnName("FAC_CENT_NO");

                entity.Property(e => e.FacContactPerson)
                    .HasColumnName("FAC_CONTACT_PERSON")
                    .HasMaxLength(100);

                entity.Property(e => e.FacDistNo).HasColumnName("FAC_DIST_NO");

                entity.Property(e => e.FacFullAddr)
                    .HasColumnName("FAC_FULL_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.IpAddr)
                    .HasColumnName("IP_ADDR")
                    .HasMaxLength(100);

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCancel).HasColumnName("IS_CANCEL");

                entity.Property(e => e.IsEmailActivated)
                    .HasColumnName("IS_EMAIL_ACTIVATED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFair).HasColumnName("IS_FAIR");

                entity.Property(e => e.IsImported).HasColumnName("IS_IMPORTED");

                entity.Property(e => e.IsLocked)
                    .HasColumnName("IS_LOCKED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsMobileActivated)
                    .HasColumnName("IS_MOBILE_ACTIVATED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPassChangeReq).HasColumnName("IS_PASS_CHANGE_REQ");

                entity.Property(e => e.IsSmartApply)
                    .HasColumnName("IS_SMART_APPLY")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsTinRequest).HasColumnName("IS_TIN_REQUEST");

                entity.Property(e => e.LockReason)
                    .HasColumnName("LOCK_REASON")
                    .HasMaxLength(500);

                entity.Property(e => e.LogonName)
                    .IsRequired()
                    .HasColumnName("LOGON_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.LogonPass)
                    .IsRequired()
                    .HasColumnName("LOGON_PASS")
                    .HasMaxLength(500);

                entity.Property(e => e.MobPass)
                    .HasColumnName("MOB_PASS")
                    .HasMaxLength(500);

                entity.Property(e => e.Mobile)
                    .HasColumnName("MOBILE")
                    .HasMaxLength(100);

                entity.Property(e => e.MobileActivateCode)
                    .HasColumnName("MOBILE_ACTIVATE_CODE")
                    .HasMaxLength(100);

                entity.Property(e => e.MobileActivateTime)
                    .HasColumnName("MOBILE_ACTIVATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.MobileActiveIpAddr)
                    .HasColumnName("MOBILE_ACTIVE_IP_ADDR")
                    .HasMaxLength(100);

                entity.Property(e => e.MobileSub)
                    .HasColumnName("MOBILE_SUB")
                    .HasMaxLength(9)
                    .HasComputedColumnSql("(right([MOBILE],(9)))");

                entity.Property(e => e.Nid)
                    .HasColumnName("NID")
                    .HasMaxLength(200);

                entity.Property(e => e.NidBfathName)
                    .HasColumnName("NID_BFATH_NAME")
                    .HasMaxLength(1000);

                entity.Property(e => e.NidBmothName)
                    .HasColumnName("NID_BMOTH_NAME")
                    .HasMaxLength(1000);

                entity.Property(e => e.NidBname)
                    .HasColumnName("NID_BNAME")
                    .HasMaxLength(1000);

                entity.Property(e => e.NidBperAddr)
                    .HasColumnName("NID_BPER_ADDR")
                    .HasMaxLength(1000);

                entity.Property(e => e.NidBpreAddr)
                    .HasColumnName("NID_BPRE_ADDR")
                    .HasMaxLength(1000);

                entity.Property(e => e.NidBspouseName)
                    .HasColumnName("NID_BSPOUSE_NAME")
                    .HasMaxLength(1000);

                entity.Property(e => e.NidDob)
                    .HasColumnName("NID_DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.NidName)
                    .HasColumnName("NID_NAME")
                    .HasMaxLength(1000);

                entity.Property(e => e.PassSalt)
                    .IsRequired()
                    .HasColumnName("PASS_SALT")
                    .HasMaxLength(500);

                entity.Property(e => e.RangeNo).HasColumnName("RANGE_NO");

                entity.Property(e => e.RegisterTime)
                    .HasColumnName("REGISTER_TIME")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(1000);

                entity.Property(e => e.SecAnswer)
                    .HasColumnName("SEC_ANSWER")
                    .HasMaxLength(500);

                entity.Property(e => e.SecQuiz)
                    .HasColumnName("SEC_QUIZ")
                    .HasMaxLength(500);

                entity.Property(e => e.SmartId)
                    .HasColumnName("SMART_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");

                entity.Property(e => e.UpdateLogonHisNo).HasColumnName("UPDATE_LOGON_HIS_NO");

                entity.Property(e => e.UpdateReason)
                    .HasColumnName("UPDATE_REASON")
                    .HasMaxLength(500);

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserNo).HasColumnName("UPDATE_USER_NO");

                entity.Property(e => e.UserTypeNo)
                    .HasColumnName("USER_TYPE_NO")
                    .HasDefaultValueSql("((4))");

                entity.Property(e => e.ZoneNo).HasColumnName("ZONE_NO");

                entity.HasOne(d => d.CircleNoNavigation)
                    .WithMany(p => p.NbrUsers)
                    .HasForeignKey(d => d.CircleNo)
                    .HasConstraintName("FK_NBR_USERS_GEN_CIRCLE_INFO");

                entity.HasOne(d => d.FacDistNoNavigation)
                    .WithMany(p => p.NbrUsers)
                    .HasForeignKey(d => d.FacDistNo)
                    .HasConstraintName("FK_NBR_USERS_GEN_DISTRICT");

                entity.HasOne(d => d.RangeNoNavigation)
                    .WithMany(p => p.NbrUsers)
                    .HasForeignKey(d => d.RangeNo)
                    .HasConstraintName("FK_NBR_USERS_GEN_RANGE_INFO");

                entity.HasOne(d => d.UserTypeNoNavigation)
                    .WithMany(p => p.NbrUsers)
                    .HasForeignKey(d => d.UserTypeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_USERS_GEN_USER_TYPE");

                entity.HasOne(d => d.ZoneNoNavigation)
                    .WithMany(p => p.NbrUsers)
                    .HasForeignKey(d => d.ZoneNo)
                    .HasConstraintName("FK_NBR_USERS_GEN_ZONE_INFO");
            });

            modelBuilder.Entity<NbrUsersClaim>(entity =>
            {
                entity.HasKey(e => e.ClaimUserNo);

                entity.ToTable("NBR_USERS_CLAIM");

                entity.HasIndex(e => new { e.ApproveTypeNum, e.Mobile })
                    .HasName("IX_NBR_USERS_CLAIM_GET");

                entity.Property(e => e.ClaimUserNo).HasColumnName("CLAIM_USER_NO");

                entity.Property(e => e.ApproveComments)
                    .HasColumnName("APPROVE_COMMENTS")
                    .HasMaxLength(1000);

                entity.Property(e => e.ApproveLogonNo).HasColumnName("APPROVE_LOGON_NO");

                entity.Property(e => e.ApproveTime)
                    .HasColumnName("APPROVE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApproveTypeNum).HasColumnName("APPROVE_TYPE_NUM");

                entity.Property(e => e.ApproveUserNo).HasColumnName("APPROVE_USER_NO");

                entity.Property(e => e.AssesName)
                    .IsRequired()
                    .HasColumnName("ASSES_NAME")
                    .HasMaxLength(1000);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("CREATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmailActivateCode)
                    .HasColumnName("EMAIL_ACTIVATE_CODE")
                    .HasMaxLength(100);

                entity.Property(e => e.EmailActivateTime)
                    .HasColumnName("EMAIL_ACTIVATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmailActiveIpAddr)
                    .HasColumnName("EMAIL_ACTIVE_IP_ADDR")
                    .HasMaxLength(100);

                entity.Property(e => e.EmailAddr)
                    .HasColumnName("EMAIL_ADDR")
                    .HasMaxLength(100);

                entity.Property(e => e.FacCentNo).HasColumnName("FAC_CENT_NO");

                entity.Property(e => e.IpAddr)
                    .HasColumnName("IP_ADDR")
                    .HasMaxLength(100);

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.IsEmailActivated).HasColumnName("IS_EMAIL_ACTIVATED");

                entity.Property(e => e.IsMobileActivated).HasColumnName("IS_MOBILE_ACTIVATED");

                entity.Property(e => e.LogonName)
                    .IsRequired()
                    .HasColumnName("LOGON_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.LogonPass)
                    .IsRequired()
                    .HasColumnName("LOGON_PASS")
                    .HasMaxLength(500);

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasColumnName("MOBILE")
                    .HasMaxLength(100);

                entity.Property(e => e.MobileActivateCode)
                    .HasColumnName("MOBILE_ACTIVATE_CODE")
                    .HasMaxLength(100);

                entity.Property(e => e.MobileActivateTime)
                    .HasColumnName("MOBILE_ACTIVATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.MobileActiveIpAddr)
                    .HasColumnName("MOBILE_ACTIVE_IP_ADDR")
                    .HasMaxLength(100);

                entity.Property(e => e.NewTin)
                    .IsRequired()
                    .HasColumnName("NEW_TIN")
                    .HasMaxLength(200);

                entity.Property(e => e.PassSalt)
                    .IsRequired()
                    .HasColumnName("PASS_SALT")
                    .HasMaxLength(500);

                entity.Property(e => e.RegisterTime)
                    .HasColumnName("REGISTER_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.SecAnswer)
                    .HasColumnName("SEC_ANSWER")
                    .HasMaxLength(500);

                entity.Property(e => e.SecQuiz)
                    .HasColumnName("SEC_QUIZ")
                    .HasMaxLength(500);

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");

                entity.Property(e => e.UserTypeNo).HasColumnName("USER_TYPE_NO");

                entity.HasOne(d => d.TinInfoNoNavigation)
                    .WithMany(p => p.NbrUsersClaim)
                    .HasForeignKey(d => d.TinInfoNo)
                    .HasConstraintName("FK_NBR_USERS_CLAIM_NBR_TIN_INFO");
            });

            modelBuilder.Entity<NbrUsersHis>(entity =>
            {
                entity.HasKey(e => e.UserHisNo);

                entity.ToTable("NBR_USERS_HIS");

                entity.Property(e => e.UserHisNo).HasColumnName("USER_HIS_NO");

                entity.Property(e => e.AdmDepartment)
                    .HasColumnName("ADM_DEPARTMENT")
                    .HasMaxLength(100);

                entity.Property(e => e.AdmDesignation)
                    .HasColumnName("ADM_DESIGNATION")
                    .HasMaxLength(100);

                entity.Property(e => e.AdmFullName)
                    .HasColumnName("ADM_FULL_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.AdmOrganization)
                    .HasColumnName("ADM_ORGANIZATION")
                    .HasMaxLength(500);

                entity.Property(e => e.ApplicationQty).HasColumnName("APPLICATION_QTY");

                entity.Property(e => e.CircleNo).HasColumnName("CIRCLE_NO");

                entity.Property(e => e.CreateLogonHisNo).HasColumnName("CREATE_LOGON_HIS_NO");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("CREATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserNo).HasColumnName("CREATE_USER_NO");

                entity.Property(e => e.EmailActivateCode)
                    .HasColumnName("EMAIL_ACTIVATE_CODE")
                    .HasMaxLength(100);

                entity.Property(e => e.EmailActivateTime)
                    .HasColumnName("EMAIL_ACTIVATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmailActiveIpAddr)
                    .HasColumnName("EMAIL_ACTIVE_IP_ADDR")
                    .HasMaxLength(100);

                entity.Property(e => e.EmailAddr)
                    .HasColumnName("EMAIL_ADDR")
                    .HasMaxLength(100);

                entity.Property(e => e.FacCentName)
                    .HasColumnName("FAC_CENT_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.FacCentNo).HasColumnName("FAC_CENT_NO");

                entity.Property(e => e.FacContactPerson)
                    .HasColumnName("FAC_CONTACT_PERSON")
                    .HasMaxLength(100);

                entity.Property(e => e.FacDistNo).HasColumnName("FAC_DIST_NO");

                entity.Property(e => e.FacFullAddr)
                    .HasColumnName("FAC_FULL_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.IpAddr)
                    .HasColumnName("IP_ADDR")
                    .HasMaxLength(100);

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.IsEmailActivated).HasColumnName("IS_EMAIL_ACTIVATED");

                entity.Property(e => e.IsFair).HasColumnName("IS_FAIR");

                entity.Property(e => e.IsLocked).HasColumnName("IS_LOCKED");

                entity.Property(e => e.IsMobileActivated).HasColumnName("IS_MOBILE_ACTIVATED");

                entity.Property(e => e.IsPassChangeReq).HasColumnName("IS_PASS_CHANGE_REQ");

                entity.Property(e => e.LockReason)
                    .HasColumnName("LOCK_REASON")
                    .HasMaxLength(500);

                entity.Property(e => e.LogonName)
                    .IsRequired()
                    .HasColumnName("LOGON_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.LogonPass)
                    .IsRequired()
                    .HasColumnName("LOGON_PASS")
                    .HasMaxLength(500);

                entity.Property(e => e.MobPass)
                    .HasColumnName("MOB_PASS")
                    .HasMaxLength(500);

                entity.Property(e => e.Mobile)
                    .HasColumnName("MOBILE")
                    .HasMaxLength(100);

                entity.Property(e => e.MobileActivateCode)
                    .HasColumnName("MOBILE_ACTIVATE_CODE")
                    .HasMaxLength(100);

                entity.Property(e => e.MobileActivateTime)
                    .HasColumnName("MOBILE_ACTIVATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.MobileActiveIpAddr)
                    .HasColumnName("MOBILE_ACTIVE_IP_ADDR")
                    .HasMaxLength(100);

                entity.Property(e => e.PassSalt)
                    .IsRequired()
                    .HasColumnName("PASS_SALT")
                    .HasMaxLength(500);

                entity.Property(e => e.RangeNo).HasColumnName("RANGE_NO");

                entity.Property(e => e.RegisterTime)
                    .HasColumnName("REGISTER_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.SecAnswer)
                    .HasColumnName("SEC_ANSWER")
                    .HasMaxLength(500);

                entity.Property(e => e.SecQuiz)
                    .HasColumnName("SEC_QUIZ")
                    .HasMaxLength(500);

                entity.Property(e => e.UpdateLogonHisNo).HasColumnName("UPDATE_LOGON_HIS_NO");

                entity.Property(e => e.UpdateReason)
                    .HasColumnName("UPDATE_REASON")
                    .HasMaxLength(500);

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserNo).HasColumnName("UPDATE_USER_NO");

                entity.Property(e => e.UserNo).HasColumnName("USER_NO");

                entity.Property(e => e.UserTypeNo).HasColumnName("USER_TYPE_NO");

                entity.Property(e => e.ZoneNo).HasColumnName("ZONE_NO");
            });

            modelBuilder.Entity<NbrVatHis>(entity =>
            {
                entity.HasKey(e => e.VatHisNo);

                entity.ToTable("NBR_VAT_HIS");

                entity.Property(e => e.VatHisNo).HasColumnName("VAT_HIS_NO");

                entity.Property(e => e.DeleteLogonNo).HasColumnName("DELETE_LOGON_NO");

                entity.Property(e => e.DeleteTime)
                    .HasColumnName("DELETE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeleteUserNo).HasColumnName("DELETE_USER_NO");

                entity.Property(e => e.InsertLogonNo).HasColumnName("INSERT_LOGON_NO");

                entity.Property(e => e.InsertTime)
                    .HasColumnName("INSERT_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserNo).HasColumnName("INSERT_USER_NO");

                entity.Property(e => e.IsImported).HasColumnName("IS_IMPORTED");

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.VatInfoNo).HasColumnName("VAT_INFO_NO");

                entity.Property(e => e.VatName)
                    .HasColumnName("VAT_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.VatRegNumber)
                    .IsRequired()
                    .HasColumnName("VAT_REG_NUMBER")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<NbrVatInfo>(entity =>
            {
                entity.HasKey(e => e.VatInfoNo);

                entity.ToTable("NBR_VAT_INFO");

                entity.HasIndex(e => new { e.TinInfoNo, e.VatRegNumber })
                    .HasName("IX_NBR_VAT_INFO")
                    .IsUnique();

                entity.Property(e => e.VatInfoNo).HasColumnName("VAT_INFO_NO");

                entity.Property(e => e.InsertLogonNo).HasColumnName("INSERT_LOGON_NO");

                entity.Property(e => e.InsertTime)
                    .HasColumnName("INSERT_TIME")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUserNo).HasColumnName("INSERT_USER_NO");

                entity.Property(e => e.IsImported)
                    .HasColumnName("IS_IMPORTED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.VatName)
                    .HasColumnName("VAT_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.VatRegNumber)
                    .IsRequired()
                    .HasColumnName("VAT_REG_NUMBER")
                    .HasMaxLength(100);

                entity.HasOne(d => d.TinInfoNoNavigation)
                    .WithMany(p => p.NbrVatInfo)
                    .HasForeignKey(d => d.TinInfoNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_VAT_INFO_NBR_TIN_INFO");
            });

            modelBuilder.Entity<NbrVatReq>(entity =>
            {
                entity.HasKey(e => e.VatReqNo);

                entity.ToTable("NBR_VAT_REQ");

                entity.Property(e => e.VatReqNo).HasColumnName("VAT_REQ_NO");

                entity.Property(e => e.ApproveLogonNo).HasColumnName("APPROVE_LOGON_NO");

                entity.Property(e => e.ApproveStatusNum).HasColumnName("APPROVE_STATUS_NUM");

                entity.Property(e => e.ApproveTime)
                    .HasColumnName("APPROVE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApproveUserNo).HasColumnName("APPROVE_USER_NO");

                entity.Property(e => e.InsertTime)
                    .HasColumnName("INSERT_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsImported).HasColumnName("IS_IMPORTED");

                entity.Property(e => e.ReqLogonNo).HasColumnName("REQ_LOGON_NO");

                entity.Property(e => e.ReqNo).HasColumnName("REQ_NO");

                entity.Property(e => e.ReqTime)
                    .HasColumnName("REQ_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReqUserNo).HasColumnName("REQ_USER_NO");

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.VatName)
                    .HasColumnName("VAT_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.VatRegNumber)
                    .IsRequired()
                    .HasColumnName("VAT_REG_NUMBER")
                    .HasMaxLength(100);

                entity.HasOne(d => d.ReqNoNavigation)
                    .WithMany(p => p.NbrVatReq)
                    .HasForeignKey(d => d.ReqNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NBR_VAT_REQ_NBR_TIN_STATUS_REQ");
            });

            modelBuilder.Entity<NbrWebApiUser>(entity =>
            {
                entity.ToTable("NBR_WEB_API_USER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.UserNo).HasColumnName("USER_NO");

                entity.Property(e => e.UserRole)
                    .IsRequired()
                    .HasColumnName("USER_ROLE")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OldCircleLocation>(entity =>
            {
                entity.HasKey(e => e.PkNo);

                entity.ToTable("OLD_CIRCLE_LOCATION");

                entity.HasIndex(e => new { e.CircleNo, e.Location })
                    .HasName("IX_OLD_CIRCLE_LOCATION")
                    .IsUnique();

                entity.Property(e => e.PkNo).HasColumnName("PK_NO");

                entity.Property(e => e.CircleCode)
                    .IsRequired()
                    .HasColumnName("CIRCLE_CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.CircleName)
                    .IsRequired()
                    .HasColumnName("CIRCLE_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.CircleNo).HasColumnName("CIRCLE_NO");

                entity.Property(e => e.DistName)
                    .IsRequired()
                    .HasColumnName("DIST_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.DistNo).HasColumnName("DIST_NO");

                entity.Property(e => e.Location)
                    .HasColumnName("LOCATION")
                    .HasMaxLength(255);

                entity.Property(e => e.ZoneCode)
                    .HasColumnName("ZONE_CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.ZoneName)
                    .IsRequired()
                    .HasColumnName("ZONE_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.ZoneNo).HasColumnName("ZONE_NO");
            });

            modelBuilder.Entity<OldCurrentLocData>(entity =>
            {
                entity.HasKey(e => e.PkCol);

                entity.ToTable("OLD_current_loc_data");

                entity.Property(e => e.PkCol).HasColumnName("PK_COL");

                entity.Property(e => e.Aname)
                    .HasColumnName("aname")
                    .HasMaxLength(255);

                entity.Property(e => e.Anid)
                    .HasColumnName("anid")
                    .HasMaxLength(255);

                entity.Property(e => e.CircleN)
                    .HasColumnName("circle_n")
                    .HasMaxLength(255);

                entity.Property(e => e.CurLoc)
                    .HasColumnName("cur_loc")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrAddr)
                    .HasColumnName("curr_addr")
                    .HasMaxLength(255);

                entity.Property(e => e.DobInc)
                    .HasColumnName("dob_inc")
                    .HasMaxLength(255);

                entity.Property(e => e.Enttin)
                    .HasColumnName("enttin")
                    .HasMaxLength(255);

                entity.Property(e => e.Fname)
                    .HasColumnName("fname")
                    .HasMaxLength(255);

                entity.Property(e => e.Mname)
                    .HasColumnName("mname")
                    .HasMaxLength(255);

                entity.Property(e => e.MobileNo)
                    .HasColumnName("mobile_no")
                    .HasMaxLength(255);

                entity.Property(e => e.PerAdd)
                    .HasColumnName("per_add")
                    .HasMaxLength(255);

                entity.Property(e => e.Spname)
                    .HasColumnName("spname")
                    .HasMaxLength(255);

                entity.Property(e => e.Thiscorc)
                    .HasColumnName("thiscorc")
                    .HasMaxLength(255);

                entity.Property(e => e.Tin)
                    .HasColumnName("tin")
                    .HasMaxLength(255);

                entity.Property(e => e.Xlfile)
                    .HasColumnName("xlfile")
                    .HasMaxLength(255);

                entity.Property(e => e.ZoneN)
                    .HasColumnName("zone_n")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<OldNbrTinData>(entity =>
            {
                entity.HasKey(e => e.OldTinNo);

                entity.ToTable("OLD_NBR_TIN_DATA");

                entity.HasIndex(e => e.Tin)
                    .HasName("IX_OLD_NBR_TIN_DATA")
                    .IsUnique();

                entity.Property(e => e.OldTinNo).HasColumnName("OLD_TIN_NO");

                entity.Property(e => e.Aname)
                    .HasColumnName("ANAME")
                    .HasMaxLength(40);

                entity.Property(e => e.Anid)
                    .HasColumnName("ANID")
                    .HasMaxLength(25);

                entity.Property(e => e.CreateLogonHisNo).HasColumnName("CREATE_LOGON_HIS_NO");

                entity.Property(e => e.CreateReason)
                    .HasColumnName("CREATE_REASON")
                    .HasMaxLength(1000);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("CREATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserNo).HasColumnName("CREATE_USER_NO");

                entity.Property(e => e.CurLoc)
                    .HasColumnName("CUR_LOC")
                    .HasMaxLength(3);

                entity.Property(e => e.CurrAddr)
                    .HasColumnName("CURR_ADDR")
                    .HasMaxLength(100);

                entity.Property(e => e.DobInc)
                    .HasColumnName("DOB_INC")
                    .HasMaxLength(40);

                entity.Property(e => e.Fname)
                    .HasColumnName("FNAME")
                    .HasMaxLength(40);

                entity.Property(e => e.IsValid)
                    .HasColumnName("IS_VALID")
                    .HasMaxLength(100);

                entity.Property(e => e.Issuedate)
                    .HasColumnName("ISSUEDATE")
                    .HasMaxLength(40);

                entity.Property(e => e.Mname)
                    .HasColumnName("MNAME")
                    .HasMaxLength(40);

                entity.Property(e => e.MobileNo)
                    .HasColumnName("MOBILE_NO")
                    .HasMaxLength(15);

                entity.Property(e => e.OldCurLocV1)
                    .HasColumnName("OLD_CUR_LOC_V1")
                    .HasMaxLength(3);

                entity.Property(e => e.PerAdd)
                    .HasColumnName("PER_ADD")
                    .HasMaxLength(100);

                entity.Property(e => e.Spname)
                    .HasColumnName("SPNAME")
                    .HasMaxLength(40);

                entity.Property(e => e.TakenNm)
                    .HasColumnName("TAKEN_NM")
                    .HasMaxLength(40);

                entity.Property(e => e.Tin)
                    .HasColumnName("TIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OldNbrVatData>(entity =>
            {
                entity.HasKey(e => e.OldVatNo);

                entity.ToTable("OLD_NBR_VAT_DATA");

                entity.HasIndex(e => e.Bin)
                    .HasName("IX_OLD_NBR_VAT_DATA")
                    .IsUnique();

                entity.Property(e => e.OldVatNo).HasColumnName("OLD_VAT_NO");

                entity.Property(e => e.Add1)
                    .HasColumnName("add1")
                    .HasMaxLength(255);

                entity.Property(e => e.Add2)
                    .HasColumnName("add2")
                    .HasMaxLength(255);

                entity.Property(e => e.Add3)
                    .HasColumnName("add3")
                    .HasMaxLength(255);

                entity.Property(e => e.Add4)
                    .HasColumnName("add4")
                    .HasMaxLength(255);

                entity.Property(e => e.Bin)
                    .HasColumnName("bin")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<OldTinInfo>(entity =>
            {
                entity.HasKey(e => e.OldTinNo);

                entity.ToTable("OLD_TIN_INFO");

                entity.HasIndex(e => e.OldTinNo)
                    .HasName("IX_OLD_TIN_INFO")
                    .IsUnique();

                entity.Property(e => e.OldTinNo).HasColumnName("OLD_TIN_NO");

                entity.Property(e => e.AssesName)
                    .IsRequired()
                    .HasColumnName("ASSES_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.ContactEmailAddr)
                    .HasColumnName("CONTACT_EMAIL_ADDR")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactFax)
                    .HasColumnName("CONTACT_FAX")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactTelephone)
                    .HasColumnName("CONTACT_TELEPHONE")
                    .HasMaxLength(100);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.FathName)
                    .HasColumnName("FATH_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.MothName)
                    .HasColumnName("MOTH_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.OldTin)
                    .IsRequired()
                    .HasColumnName("OLD_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.SpouseName)
                    .HasColumnName("SPOUSE_NAME")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<OldVatdata>(entity =>
            {
                entity.HasKey(e => e.VatNo);

                entity.ToTable("OLD_vatdata");

                entity.Property(e => e.VatNo).HasColumnName("vat_no");

                entity.Property(e => e.Add1)
                    .HasColumnName("add1")
                    .HasMaxLength(255);

                entity.Property(e => e.Add2)
                    .HasColumnName("add2")
                    .HasMaxLength(255);

                entity.Property(e => e.Add3)
                    .HasColumnName("add3")
                    .HasMaxLength(255);

                entity.Property(e => e.Add4)
                    .HasColumnName("add4")
                    .HasMaxLength(255);

                entity.Property(e => e.Bin)
                    .HasColumnName("bin")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<RjscBusinessInfo>(entity =>
            {
                entity.HasKey(e => e.RjscBusiNo);

                entity.ToTable("RJSC_BUSINESS_INFO");

                entity.Property(e => e.RjscBusiNo).HasColumnName("RJSC_BUSI_NO");

                entity.Property(e => e.BusiTypeNo).HasColumnName("BUSI_TYPE_NO");

                entity.Property(e => e.RjscBusiName)
                    .IsRequired()
                    .HasColumnName("RJSC_BUSI_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.RjscBusiTin)
                    .IsRequired()
                    .HasColumnName("RJSC_BUSI_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.RjscIncoprNo).HasColumnName("RJSC_INCOPR_NO");

                entity.HasOne(d => d.RjscIncoprNoNavigation)
                    .WithMany(p => p.RjscBusinessInfo)
                    .HasForeignKey(d => d.RjscIncoprNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RJSC_BUSINESS_INFO_RJSC_INCORP_INFO");
            });

            modelBuilder.Entity<RjscIncorpInfo>(entity =>
            {
                entity.HasKey(e => e.RjscIncoprNo);

                entity.ToTable("RJSC_INCORP_INFO");

                entity.Property(e => e.RjscIncoprNo).HasColumnName("RJSC_INCOPR_NO");

                entity.Property(e => e.IncorpDate)
                    .HasColumnName("INCORP_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.IncorpNumber)
                    .IsRequired()
                    .HasColumnName("INCORP_NUMBER")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TrnTinLog>(entity =>
            {
                entity.HasKey(e => e.LogNo);

                entity.ToTable("TRN_TIN_LOG");

                entity.HasIndex(e => new { e.TinInfoNo, e.LogNo })
                    .HasName("IX_TRN_TIN_LOG_GET");

                entity.Property(e => e.LogNo).HasColumnName("LOG_NO");

                entity.Property(e => e.IsLocked).HasColumnName("IS_LOCKED");

                entity.Property(e => e.IsSync).HasColumnName("IS_SYNC");

                entity.Property(e => e.LogMode)
                    .IsRequired()
                    .HasColumnName("LOG_MODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LogTime)
                    .HasColumnName("LOG_TIME")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TinInfoNo).HasColumnName("TIN_INFO_NO");
            });

            modelBuilder.Entity<WsRequestDetail>(entity =>
            {
                entity.HasKey(e => e.WsReqDetNo);

                entity.ToTable("WS_REQUEST_DETAIL");

                entity.Property(e => e.WsReqDetNo).HasColumnName("WS_REQ_DET_NO");

                entity.Property(e => e.ParamName).HasColumnName("PARAM_NAME");

                entity.Property(e => e.ParamVal).HasColumnName("PARAM_VAL");

                entity.Property(e => e.WsReqMastNo).HasColumnName("WS_REQ_MAST_NO");

                entity.HasOne(d => d.WsReqMastNoNavigation)
                    .WithMany(p => p.WsRequestDetail)
                    .HasForeignKey(d => d.WsReqMastNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WS_REQUEST_DETAIL_WS_REQUEST_MASTER");
            });

            modelBuilder.Entity<WsRequestMaster>(entity =>
            {
                entity.HasKey(e => e.WsReqMastNo);

                entity.ToTable("WS_REQUEST_MASTER");

                entity.Property(e => e.WsReqMastNo).HasColumnName("WS_REQ_MAST_NO");

                entity.Property(e => e.IpAddr)
                    .HasColumnName("IP_ADDR")
                    .HasMaxLength(500);

                entity.Property(e => e.LogonHisNo).HasColumnName("LOGON_HIS_NO");

                entity.Property(e => e.MethodName)
                    .HasColumnName("METHOD_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.RequestTime)
                    .HasColumnName("REQUEST_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.SessId)
                    .HasColumnName("SESS_ID")
                    .HasMaxLength(500);

                entity.Property(e => e.UserNo).HasColumnName("USER_NO");
            });

            modelBuilder.Entity<NbrWebApiTinValidationTracker>(entity =>
            {
                entity.HasKey(e => e.TrackerId);

                entity.ToTable("NBR_WEB_API_TIN_VALIDATION_TRACKER");

                entity.Property(e => e.TrackerId).HasColumnName("TRACKER_ID");

                entity.Property(e => e.NewTin)
                    .HasColumnName("NEW_TIN")
                    .HasMaxLength(100);

                entity.Property(e => e.UserNo)
                    .HasColumnName("USER_NO");

                entity.Property(e => e.AssesName)
                    .HasColumnName("ASSES_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.Mobile)
                    .HasColumnName("MOBILE")
                    .HasMaxLength(100);

                entity.Property(e => e.IpAddr)
                    .HasColumnName("IP_ADDR")
                    .HasMaxLength(100);

                entity.Property(e => e.CircleNo)
                    .HasColumnName("CIRCLE_NO");

                entity.Property(e => e.Nid)
                    .HasColumnName("NID")
                    .HasMaxLength(200);

                entity.Property(e => e.PassportNumber)
                    .HasColumnName("PASSPORT_NUMBER")
                    .HasMaxLength(200);

                entity.Property(e => e.AuthId)
                    .HasColumnName("AUTH_ID");

                entity.Property(e => e.InsertTime)
                    .HasColumnName("INSERT_TIME")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<NbrWebApiAuthTracker>(entity =>
            {
                entity.HasKey(e => e.AuthId);

                entity.ToTable("NBR_WEB_API_AUTH_TRACKER");

                entity.Property(e => e.AuthId).HasColumnName("AUTH_ID");

                entity.Property(e => e.InsertTime)
                    .HasColumnName("INSERT_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExpireTime)
                    .HasColumnName("EXPIRE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.IpAddr)
                    .HasColumnName("IP_ADDRESS")
                    .HasMaxLength(100);

                entity.Property(e => e.UserNo)
                    .HasColumnName("USER_NO");
            });
        }
    }
}
