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

        public virtual DbSet<NbrTinInfo> NbrTinInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=172.21.16.52;Database=NBR_LIVE_DB_test;user id=sa;password=SqlServer2008;Connection Timeout=180;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

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
                    .HasDefaultValueSql("((0))");

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
            });
        }
    }
}
