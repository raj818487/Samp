using Audit.EntityFramework;
using Microsoft.EntityFrameworkCore;
using SAMP.Domain.Entities;

namespace SAMP.Persistence;
public class DataContext : AuditDbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccDetail>(entity =>
        {
            entity.HasKey(e => new { e.AccReqId, e.RoomId });

            entity.ToTable("AccDetail");

            entity.HasIndex(e => e.AccReqId, "IX_AccDetail_AccReqId");

            entity.HasIndex(e => e.ActCheckInTime, "IX_AccDetail_ActCheckInTime");

            entity.HasIndex(e => e.AllotedById, "IX_AccDetail_AllotedById");

            entity.HasIndex(e => e.CounterCheckInTime, "IX_AccDetail_CounterCheckInTime");

            entity.HasIndex(e => e.CounterCheckOutTime, "IX_AccDetail_CounterCheckOutTime");

            entity.HasIndex(e => e.RoomId, "IX_AccDetail_RoomId");

            entity.HasOne(d => d.AccReq).WithMany(p => p.AccDetails)
                .HasForeignKey(d => d.AccReqId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.AllotedBy).WithMany(p => p.AccDetails)
                .HasForeignKey(d => d.AllotedById)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Room).WithMany(p => p.AccDetails)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<AccReq>(entity =>
        {
            entity.ToTable("AccReq");

            entity.HasKey(e => e.Id); 

            entity.Property(e => e.Id)
                  .UseIdentityColumn();

            entity.HasIndex(e => e.BookingRefId, "IX_AccReq_BookingRefId");

            entity.Property(e => e.BookingRefId)
                  .UseIdentityColumn();

            entity.HasIndex(e => e.BookingRefNo, "IX_AccReq_BookingRefNo").IsUnique();

            entity.HasIndex(e => e.Category, "IX_AccReq_Category");

            entity.HasIndex(e => e.CityId, "IX_AccReq_CityId");

            entity.HasIndex(e => e.CreatedAt, "IX_AccReq_CreatedAt");

            entity.HasIndex(e => e.CreatedById, "IX_AccReq_CreatedById");

            entity.HasIndex(e => e.ExpCheckInTime, "IX_AccReq_ExpCheckInTime");

            entity.HasIndex(e => e.ExpCheckOutTime, "IX_AccReq_ExpCheckOutTime");

            entity.HasIndex(e => e.HaribhaktId, "IX_AccReq_HaribhaktId");

            entity.HasIndex(e => e.ModifiedAt, "IX_AccReq_ModifiedAt");

            entity.HasIndex(e => e.ModifiedById, "IX_AccReq_ModifiedById");

            entity.HasIndex(e => e.ReqTransModeId, "IX_AccReq_ReqTransModeId");

            entity.HasIndex(e => e.StatusId, "IX_AccReq_StatusId");

            entity.HasIndex(e => e.UtsavId, "IX_AccReq_UtsavId");

            entity.Property(e => e.Deposit).HasColumnType("DECIMAL(12, 2)");
            entity.Property(e => e.PaidRent).HasColumnType("DECIMAL(12, 2)");
            entity.Property(e => e.ReturnedDeposit).HasColumnType("DECIMAL(12, 2)");

            entity.HasOne(d => d.City).WithMany(p => p.AccReqs)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.CreatedBy).WithMany(p => p.AccReqCreatedBies)
                .HasForeignKey(d => d.CreatedById)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ModifiedBy).WithMany(p => p.AccReqModifiedBies)
                .HasForeignKey(d => d.ModifiedById)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ReqTransMode).WithMany(p => p.AccReqs)
                .HasForeignKey(d => d.ReqTransModeId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Status).WithMany(p => p.AccReqs)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Utsav).WithMany(p => p.AccReqs)
                .HasForeignKey(d => d.UtsavId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<AccReqDetail>(entity =>
        {
            entity.ToTable("AccReqDetail");

            entity.HasIndex(e => e.AccReqId, "IX_AccReqDetail_AccReqId");

            entity.HasIndex(e => e.RelationId, "IX_AccReqDetail_RelationId");

            entity.HasOne(d => d.AccReq).WithMany(p => p.AccReqDetails)
                .HasForeignKey(d => d.AccReqId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Relation).WithMany(p => p.AccReqDetails)
                .HasForeignKey(d => d.RelationId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<AccReqStatus>(entity =>
        {
            entity.ToTable("AccReqStatus");

            entity.HasIndex(e => e.Name, "IX_AccReqStatus_Name").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<AccReqToken>(entity =>
        {
            entity.ToTable("AccReqToken");

            entity.HasIndex(e => e.AccReqId, "IX_AccReqToken_AccReqId");

            entity.HasIndex(e => e.CreatedAt, "IX_AccReqToken_CreatedAt");

            entity.HasIndex(e => e.CreatedById, "IX_AccReqToken_CreatedById");

            entity.HasIndex(e => e.HashToken, "IX_AccReqToken_HashToken");

            entity.HasIndex(e => e.InviterCityId, "IX_AccReqToken_InviterCityId");

            entity.HasIndex(e => e.ModifiedAt, "IX_AccReqToken_ModifiedAt");

            entity.HasIndex(e => e.ModifiedById, "IX_AccReqToken_ModifiedById");

            entity.HasOne(d => d.AccReq).WithMany(p => p.AccReqTokens)
                .HasForeignKey(d => d.AccReqId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.InviterCity).WithMany(p => p.AccReqTokens)
                .HasForeignKey(d => d.InviterCityId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Aitype>(entity =>
        {
            entity.ToTable("AIType");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasMany(d => d.Amenities).WithMany(p => p.Aitypes)
                .UsingEntity<Dictionary<string, object>>(
                    "AitypeAmenity",
                    r => r.HasOne<Amenity>().WithMany().HasForeignKey("AmenityId"),
                    l => l.HasOne<Aitype>().WithMany().HasForeignKey("AitypeId"),
                    j =>
                    {
                        j.HasKey("AitypeId", "AmenityId");
                        j.ToTable("AITypeAmenity");
                        j.HasIndex(new[] { "AitypeId" }, "IX_AITypeAmenity_AITypeId");
                        j.HasIndex(new[] { "AmenityId" }, "IX_AITypeAmenity_AmenityId");
                        j.IndexerProperty<int>("AitypeId").HasColumnName("AITypeId");
                    });

            entity.HasMany(d => d.Inventories).WithMany(p => p.Aitypes)
                .UsingEntity<Dictionary<string, object>>(
                    "AitypeInventory",
                    r => r.HasOne<Inventory>().WithMany().HasForeignKey("InventoryId"),
                    l => l.HasOne<Aitype>().WithMany().HasForeignKey("AitypeId"),
                    j =>
                    {
                        j.HasKey("AitypeId", "InventoryId");
                        j.ToTable("AITypeInventory");
                        j.HasIndex(new[] { "AitypeId" }, "IX_AITypeInventory_AITypeId");
                        j.HasIndex(new[] { "InventoryId" }, "IX_AITypeInventory_InventoryId");
                        j.IndexerProperty<int>("AitypeId").HasColumnName("AITypeId");
                    });
        });

        modelBuilder.Entity<Amenity>(entity =>
        {
            entity.ToTable("Amenity");

            entity.HasIndex(e => e.Name, "IX_Amenity_Name").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex").IsUnique();

            entity.HasIndex(e => e.Name, "UQ_AspNetRoles_Name").IsUnique();

            entity.HasMany(d => d.QueryRoomGroups).WithMany(p => p.Roles)
                .UsingEntity<Dictionary<string, object>>(
                    "RoleQueryRoomGroup",
                    r => r.HasOne<QueryRoomGroup>().WithMany()
                        .HasForeignKey("QueryRoomGroupId")
                        .OnDelete(DeleteBehavior.Restrict),
                    l => l.HasOne<AspNetRole>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict),
                    j =>
                    {
                        j.HasKey("RoleId", "QueryRoomGroupId");
                        j.ToTable("RoleQueryRoomGroup");
                    });
        });

        modelBuilder.Entity<AspNetRoleClaim>(entity =>
        {
            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.CityId, "IX_AspNetUsers_CityId");

            entity.HasIndex(e => e.PhoneNumber, "IX_AspNetUsers_PhoneNumber").IsUnique();

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex").IsUnique();

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.ToTable("AspNetUserRoles");
                        j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.ToTable("City");

            entity.HasIndex(e => e.Name, "IX_City_Name");

            entity.HasIndex(e => e.StateId, "IX_City_StateId");

            entity.HasIndex(e => e.Type, "IX_City_Type");

            entity.Property(e => e.Type).HasDefaultValue("C");

            entity.HasOne(d => d.State).WithMany(p => p.Cities)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.ToTable("Contact");

            entity.HasIndex(e => e.UniqueId, "IX_Contact_UniqueId").IsUnique();

            entity.HasIndex(e => e.UtsavId, "IX_Contact_UtsavId");

            entity.HasOne(d => d.Utsav).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.UtsavId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<ContactPhone>(entity =>
        {
            entity.ToTable("ContactPhone");

            entity.HasIndex(e => e.ContactId, "IX_ContactPhone_ContactId");

            entity.HasOne(d => d.Contact).WithMany(p => p.ContactPhones)
                .HasForeignKey(d => d.ContactId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<ContactType>(entity =>
        {
            entity.ToTable("ContactType");

            entity.HasIndex(e => e.Name, "IX_ContactType_Name").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Continent>(entity =>
        {
            entity.ToTable("Continent");

            entity.HasIndex(e => e.Name, "IX_Continent_Name").IsUnique();
         
        });

        modelBuilder.Entity<Counter>(entity =>
        {
            entity.ToTable("Counter");

            entity.HasIndex(e => e.CreatedAt, "IX_Counter_CreatedAt");

            entity.HasIndex(e => e.CreatedById, "IX_Counter_CreatedById");

            entity.HasIndex(e => e.ModifiedAt, "IX_Counter_ModifiedAt");

            entity.HasIndex(e => e.ModifiedById, "IX_Counter_ModifiedById");

            entity.HasIndex(e => e.UtsavId, "IX_Counter_UtsavId");

            entity.HasOne(d => d.CreatedBy).WithMany(p => p.CounterCreatedBies)
                .HasForeignKey(d => d.CreatedById)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ModifiedBy).WithMany(p => p.CounterModifiedBies)
                .HasForeignKey(d => d.ModifiedById)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Utsav).WithMany(p => p.Counters)
                .HasForeignKey(d => d.UtsavId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<CounterRoomGroup>(entity =>
        {
            entity.HasKey(e => new { e.UtsavId, e.CounterId, e.RoomGroupId });

            entity.ToTable("CounterRoomGroup");

            entity.HasIndex(e => e.CounterId, "IX_CounterRoomGroup_CounterId");

            entity.HasIndex(e => e.RoomGroupId, "IX_CounterRoomGroup_RoomGroupId");

            entity.HasOne(d => d.Counter).WithMany(p => p.CounterRoomGroups)
                .HasForeignKey(d => d.CounterId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.RoomGroup).WithMany(p => p.CounterRoomGroups)
                .HasForeignKey(d => d.RoomGroupId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Utsav).WithMany(p => p.CounterRoomGroups)
                .HasForeignKey(d => d.UtsavId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("Country");

            entity.HasIndex(e => e.ContinentId, "IX_Country_ContinentId");

            entity.HasIndex(e => e.Name, "IX_Country_Name").IsUnique();

            entity.HasOne(d => d.Continent).WithMany(p => p.Countries)
                .HasForeignKey(d => d.ContinentId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<DeviceCode>(entity =>
        {
            entity.HasKey(e => e.UserCode);

            entity.HasIndex(e => e.DeviceCode1, "IX_DeviceCodes_DeviceCode").IsUnique();

            entity.HasIndex(e => e.Expiration, "IX_DeviceCodes_Expiration");

            entity.Property(e => e.DeviceCode1).HasColumnName("DeviceCode");
        });

        modelBuilder.Entity<Floor>(entity =>
        {
            entity.ToTable("Floor");

            entity.HasIndex(e => e.Name, "IX_Floor_Name").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Haribhakt>(entity =>
        {
            entity.ToTable("Haribhakt");

            entity.HasIndex(e => e.CountryId, "IX_Haribhakt_CountryId");

            entity.HasIndex(e => e.StateId, "IX_Haribhakt_StateId");

            entity.HasIndex(e => e.UniqueId, "IX_Haribhakt_UniqueId");

            entity.HasOne(d => d.Country).WithMany(p => p.Haribhakts)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.State).WithMany(p => p.Haribhakts)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<House>(entity =>
        {
            entity.ToTable("House");

            entity.HasIndex(e => e.AvailableFrom, "IX_House_AvailableFrom");

            entity.HasIndex(e => e.AvailableTo, "IX_House_AvailableTo");

            entity.HasIndex(e => e.CreatedAt, "IX_House_CreatedAt");

            entity.HasIndex(e => e.CreatedById, "IX_House_CreatedById");

            entity.HasIndex(e => e.HouseTypeId, "IX_House_HouseTypeId");

            entity.HasIndex(e => e.ModifiedAt, "IX_House_ModifiedAt");

            entity.HasIndex(e => e.ModifiedById, "IX_House_ModifiedById");

            entity.HasIndex(e => e.RoomGroupId, "IX_House_RoomGroupId");

            entity.HasIndex(e => e.UniqueId, "IX_House_UniqueId").IsUnique();

            entity.Property(e => e.Lat).HasColumnType("DECIMAL(12, 8)");
            entity.Property(e => e.Long).HasColumnType("DECIMAL(12, 8)");

            entity.HasOne(d => d.CreatedBy).WithMany(p => p.HouseCreatedBies)
                .HasForeignKey(d => d.CreatedById)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.HouseType).WithMany(p => p.Houses)
                .HasForeignKey(d => d.HouseTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ModifiedBy).WithMany(p => p.HouseModifiedBies)
                .HasForeignKey(d => d.ModifiedById)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.RoomGroup).WithMany(p => p.Houses)
                .HasForeignKey(d => d.RoomGroupId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<HouseAmenity>(entity =>
        {
            entity.HasKey(e => new { e.HouseId, e.AmenityId });

            entity.ToTable("HouseAmenity");

            entity.HasIndex(e => e.AmenityId, "IX_HouseAmenity_AmenityId");

            entity.HasIndex(e => e.HouseId, "IX_HouseAmenity_HouseId");

            entity.HasOne(d => d.Amenity).WithMany(p => p.HouseAmenities)
                .HasForeignKey(d => d.AmenityId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.House).WithMany(p => p.HouseAmenities)
                .HasForeignKey(d => d.HouseId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<HouseContact>(entity =>
        {
            entity.HasKey(e => new { e.HouseId, e.ContactTypeId, e.ContactId });

            entity.ToTable("HouseContact");

            entity.HasIndex(e => e.ContactId, "IX_HouseContact_ContactId");

            entity.HasIndex(e => e.ContactTypeId, "IX_HouseContact_ContactTypeId");

            entity.HasIndex(e => e.HouseId, "IX_HouseContact_HouseId");

            entity.HasOne(d => d.Contact).WithMany(p => p.HouseContacts)
                .HasForeignKey(d => d.ContactId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ContactType).WithMany(p => p.HouseContacts)
                .HasForeignKey(d => d.ContactTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.House).WithMany(p => p.HouseContacts)
                .HasForeignKey(d => d.HouseId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<HouseInventory>(entity =>
        {
            entity.HasKey(e => new { e.HouseId, e.InventoryId });

            entity.ToTable("HouseInventory");

            entity.HasIndex(e => e.HouseId, "IX_HouseInventory_HouseId");

            entity.HasIndex(e => e.InventoryId, "IX_HouseInventory_InventoryId");

            entity.HasOne(d => d.House).WithMany(p => p.HouseInventories)
                .HasForeignKey(d => d.HouseId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Inventory).WithMany(p => p.HouseInventories)
                .HasForeignKey(d => d.InventoryId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<HouseType>(entity =>
        {
            entity.ToTable("HouseType");
        });

        modelBuilder.Entity<Image>(entity =>
        {
            entity.ToTable("Image");

            entity.HasIndex(e => e.OwnerId, "IX_Image_OwnerId");

            entity.HasIndex(e => e.Src, "IX_Image_Src");

            entity.HasIndex(e => e.TypeId, "IX_Image_TypeId");

            entity.HasIndex(e => e.UniqueId, "IX_Image_UniqueId").IsUnique();

            entity.HasOne(d => d.Type).WithMany(p => p.Images)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<ImageType>(entity =>
        {
            entity.ToTable("ImageType");

            entity.HasIndex(e => e.Name, "IX_ImageType_Name").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.ToTable("Inventory");
        });

        modelBuilder.Entity<Key>(entity =>
        {
            entity.HasIndex(e => e.Use, "IX_Keys_Use");

            entity.Property(e => e.IsX509certificate).HasColumnName("IsX509Certificate");
        });

        modelBuilder.Entity<MaintenanceIssue>(entity =>
        {
            entity.ToTable("MaintenanceIssue");

            entity.HasIndex(e => e.RoomId, "IX_MaintenanceIssue_RoomId");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.CreatedBy).WithMany(p => p.MaintenanceIssueCreatedBies)
                .HasForeignKey(d => d.CreatedById)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Inventory).WithMany(p => p.MaintenanceIssues)
                .HasForeignKey(d => d.InventoryId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ModifiedBy).WithMany(p => p.MaintenanceIssueModifiedBies)
                .HasForeignKey(d => d.ModifiedById)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Room).WithMany(p => p.MaintenanceIssues)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<MemCache>(entity =>
        {
            entity.ToTable("MemCache");
        });

        modelBuilder.Entity<PersistedGrant>(entity =>
        {
            entity.HasKey(e => e.Key);

            entity.HasIndex(e => e.ConsumedTime, "IX_PersistedGrants_ConsumedTime");

            entity.HasIndex(e => e.Expiration, "IX_PersistedGrants_Expiration");

            entity.HasIndex(e => new { e.SubjectId, e.ClientId, e.Type }, "IX_PersistedGrants_SubjectId_ClientId_Type");

            entity.HasIndex(e => new { e.SubjectId, e.SessionId, e.Type }, "IX_PersistedGrants_SubjectId_SessionId_Type");
        });

        modelBuilder.Entity<PreAllotment>(entity =>
        {
            entity.HasKey(e => e.AccReqId);

            entity.ToTable("PreAllotment");

            entity.Property(e => e.AccReqId).ValueGeneratedNever();

            entity.HasOne(d => d.AccReq).WithOne(p => p.PreAllotment)
                .HasForeignKey<PreAllotment>(d => d.AccReqId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.AllotedBy).WithMany(p => p.PreAllotments)
                .HasForeignKey(d => d.AllotedById)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.QueryRoomGroup).WithMany(p => p.PreAllotments)
                .HasForeignKey(d => d.QueryRoomGroupId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<PreAllotmentDetail>(entity =>
        {
            entity.HasKey(e => new { e.AccReqId, e.RoomId });

            entity.ToTable("PreAllotmentDetail");

            entity.HasIndex(e => e.RoomId, "IX_PreAllotmentDetail_RoomId");

            entity.HasOne(d => d.AccReq).WithMany(p => p.PreAllotmentDetails)
                .HasForeignKey(d => d.AccReqId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Room).WithMany(p => p.PreAllotmentDetails)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<QueryRoomGroup>(entity =>
        {
            entity.ToTable("QueryRoomGroup");

            entity.HasIndex(e => e.CreatedAt, "IX_QueryRoomGroup_CreatedAt");

            entity.HasIndex(e => e.CreatedById, "IX_QueryRoomGroup_CreatedById");

            entity.HasIndex(e => e.ModifiedAt, "IX_QueryRoomGroup_ModifiedAt");

            entity.HasIndex(e => e.ModifiedById, "IX_QueryRoomGroup_ModifiedById");

            entity.HasIndex(e => e.Name, "IX_QueryRoomGroup_Name");

            entity.HasIndex(e => e.RgtypeId, "IX_QueryRoomGroup_RGTypeId");

            entity.HasIndex(e => e.RoomGroupId, "IX_QueryRoomGroup_RoomGroupId");

            entity.HasIndex(e => e.UtsavId, "IX_QueryRoomGroup_UtsavId");

            entity.Property(e => e.RgtypeId).HasColumnName("RGTypeId");
            entity.Property(e => e.Sql).HasColumnName("SQL");

            entity.HasOne(d => d.CreatedBy).WithMany(p => p.QueryRoomGroupCreatedBies)
                .HasForeignKey(d => d.CreatedById)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ModifiedBy).WithMany(p => p.QueryRoomGroupModifiedBies)
                .HasForeignKey(d => d.ModifiedById)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Rgtype).WithMany(p => p.QueryRoomGroups)
                .HasForeignKey(d => d.RgtypeId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.RoomGroup).WithMany(p => p.QueryRoomGroups)
                .HasForeignKey(d => d.RoomGroupId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Utsav).WithMany(p => p.QueryRoomGroups)
                .HasForeignKey(d => d.UtsavId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Relation>(entity =>
        {
            entity.ToTable("Relation");

            entity.HasIndex(e => e.Name, "IX_Relation_Name").IsUnique();

            entity.Property(e => e.Id);
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.ToTable("Report");

            entity.Property(e => e.Sql).HasColumnName("SQL");

            entity.HasMany(d => d.Roles).WithMany(p => p.Reports)
                .UsingEntity<Dictionary<string, object>>(
                    "ReportRole",
                    r => r.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<Report>().WithMany().HasForeignKey("ReportId"),
                    j =>
                    {
                        j.HasKey("ReportId", "RoleId");
                        j.ToTable("ReportRoles");
                    });
        });

        modelBuilder.Entity<ReqTransMode>(entity =>
        {
            entity.ToTable("ReqTransMode");

            entity.HasIndex(e => e.Name, "IX_ReqTransMode_Name").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<RequestMode>(entity =>
        {
            entity.ToTable("RequestMode");

            entity.HasIndex(e => e.Name, "IX_RequestMode_Name").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.ToTable("Room");

            entity.HasIndex(e => e.CreatedAt, "IX_Room_CreatedAt");

            entity.HasIndex(e => e.CreatedById, "IX_Room_CreatedById");

            entity.HasIndex(e => e.FloorId, "IX_Room_FloorId");

            entity.HasIndex(e => e.Grade, "IX_Room_Grade");

            entity.HasIndex(e => e.HouseId, "IX_Room_HouseId");

            entity.HasIndex(e => e.ModifiedAt, "IX_Room_ModifiedAt");

            entity.HasIndex(e => e.ModifiedById, "IX_Room_ModifiedById");

            entity.HasIndex(e => e.RoomGroupId, "IX_Room_RoomGroupId");

            entity.HasIndex(e => e.StatusId, "IX_Room_StatusId");

            entity.HasIndex(e => e.UniqueId, "IX_Room_UniqueId").IsUnique();

            entity.HasIndex(e => e.RoomNo, "UIX_BuildingId_RoomNo").IsUnique();

            entity.Property(e => e.Bhk).HasColumnName("BHK");
            entity.Property(e => e.DefaultRate).HasColumnType("DECIMAL(10, 2)");
            entity.Property(e => e.Deposit).HasColumnType("DECIMAL(10, 2)");
            entity.Property(e => e.RtgentsCount).HasColumnName("RTGentsCount");
            entity.Property(e => e.RtisPrivate).HasColumnName("RTIsPrivate");
            entity.Property(e => e.RtladiesCount).HasColumnName("RTLadiesCount");

            entity.HasOne(d => d.CreatedBy).WithMany(p => p.RoomCreatedBies)
                .HasForeignKey(d => d.CreatedById)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Floor).WithMany(p => p.Rooms)
                .HasForeignKey(d => d.FloorId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.House).WithMany(p => p.Rooms)
                .HasForeignKey(d => d.HouseId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ModifiedBy).WithMany(p => p.RoomModifiedBies)
                .HasForeignKey(d => d.ModifiedById)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.RoomGroup).WithMany(p => p.Rooms)
                .HasForeignKey(d => d.RoomGroupId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Status).WithMany(p => p.Rooms)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<RoomAmenity>(entity =>
        {
            entity.HasKey(e => new { e.RoomId, e.AmenityId });

            entity.ToTable("RoomAmenity");

            entity.HasIndex(e => e.AmenityId, "IX_RoomAmenity_AmenityId");

            entity.HasIndex(e => e.RoomId, "IX_RoomAmenity_RoomId");

            entity.HasOne(d => d.Amenity).WithMany(p => p.RoomAmenities)
                .HasForeignKey(d => d.AmenityId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Room).WithMany(p => p.RoomAmenities)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<RoomCleaningStatus>(entity =>
        {
            entity.ToTable("RoomCleaningStatus");

            entity.HasIndex(e => e.RoomId, "IX_RoomCleaningStatus_RoomId");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.CreatedBy).WithMany(p => p.RoomCleaningStatusCreatedBies)
                .HasForeignKey(d => d.CreatedById)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ModifiedBy).WithMany(p => p.RoomCleaningStatusModifiedBies)
                .HasForeignKey(d => d.ModifiedById)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Room).WithMany(p => p.RoomCleaningStatuses)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<RoomGroup>(entity =>
        {
            entity.ToTable("RoomGroup");

            entity.HasIndex(e => e.CreatedAt, "IX_RoomGroup_CreatedAt");

            entity.HasIndex(e => e.CreatedById, "IX_RoomGroup_CreatedById");

            entity.HasIndex(e => e.MandirUtsavId, "IX_RoomGroup_MandirUtsavId");

            entity.HasIndex(e => e.ModifiedAt, "IX_RoomGroup_ModifiedAt");

            entity.HasIndex(e => e.ModifiedById, "IX_RoomGroup_ModifiedById");

            entity.HasIndex(e => e.Name, "IX_RoomGroup_Name");

            entity.HasIndex(e => e.RgtypeId, "IX_RoomGroup_RGTypeId");

            entity.HasIndex(e => e.UniqueId, "IX_RoomGroup_UniqueId").IsUnique();

            entity.HasIndex(e => e.UtsavId, "IX_RoomGroup_UtsavId");

            entity.Property(e => e.CancellationNoticeHours).HasColumnType("DECIMAL(5, 2)");
            entity.Property(e => e.Lat).HasColumnType("DECIMAL(12, 8)");
            entity.Property(e => e.Long).HasColumnType("DECIMAL(12, 8)");
            entity.Property(e => e.RgtypeId).HasColumnName("RGTypeId");

            entity.HasOne(d => d.CreatedBy).WithMany(p => p.RoomGroupCreatedBies)
                .HasForeignKey(d => d.CreatedById)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.MandirUtsav).WithMany(p => p.RoomGroupMandirUtsavs)
                .HasForeignKey(d => d.MandirUtsavId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ModifiedBy).WithMany(p => p.RoomGroupModifiedBies)
                .HasForeignKey(d => d.ModifiedById)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Rgtype).WithMany(p => p.RoomGroups)
                .HasForeignKey(d => d.RgtypeId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Utsav).WithMany(p => p.RoomGroupUtsavs)
                .HasForeignKey(d => d.UtsavId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<RoomGroupAmenity>(entity =>
        {
            entity.HasKey(e => new { e.RoomGroupId, e.AmenityId });

            entity.ToTable("RoomGroupAmenity");

            entity.HasIndex(e => e.AmenityId, "IX_RoomGroupAmenity_AmenityId");

            entity.HasIndex(e => e.RoomGroupId, "IX_RoomGroupAmenity_RoomGroupId");

            entity.HasOne(d => d.Amenity).WithMany(p => p.RoomGroupAmenities)
                .HasForeignKey(d => d.AmenityId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.RoomGroup).WithMany(p => p.RoomGroupAmenities)
                .HasForeignKey(d => d.RoomGroupId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<RoomGroupContact>(entity =>
        {
            entity.HasKey(e => new { e.RoomGroupId, e.ContactTypeId, e.ContactId });

            entity.ToTable("RoomGroupContact");

            entity.HasIndex(e => e.ContactId, "IX_RoomGroupContact_ContactId");

            entity.HasIndex(e => e.ContactTypeId, "IX_RoomGroupContact_ContactTypeId");

            entity.HasIndex(e => e.RoomGroupId, "IX_RoomGroupContact_RoomGroupId");

            entity.HasOne(d => d.Contact).WithMany(p => p.RoomGroupContacts)
                .HasForeignKey(d => d.ContactId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ContactType).WithMany(p => p.RoomGroupContacts)
                .HasForeignKey(d => d.ContactTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.RoomGroup).WithMany(p => p.RoomGroupContacts)
                .HasForeignKey(d => d.RoomGroupId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<RoomGroupType>(entity =>
        {
            entity.ToTable("RoomGroupType");

            entity.HasIndex(e => e.Name, "IX_RoomGroupType_Name").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<RoomInventory>(entity =>
        {
            entity.HasKey(e => new { e.RoomId, e.InventoryId });

            entity.ToTable("RoomInventory");

            entity.HasIndex(e => e.InventoryId, "IX_RoomInventory_InventoryId");

            entity.HasIndex(e => e.RoomId, "IX_RoomInventory_RoomId");

            entity.HasOne(d => d.Inventory).WithMany(p => p.RoomInventories)
                .HasForeignKey(d => d.InventoryId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Room).WithMany(p => p.RoomInventories)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<RoomStatus>(entity =>
        {
            entity.ToTable("RoomStatus");

            entity.HasIndex(e => e.Name, "IX_RoomStatus_Name").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.ToTable("State");

            entity.HasIndex(e => e.CountryId, "IX_State_CountryId");

            entity.HasIndex(e => e.Name, "IX_State_Name");

            entity.HasOne(d => d.Country).WithMany(p => p.States)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<UserRoomGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UserRoomGroup");

            entity.HasIndex(e => e.RoomGroupId, "IX_UserRoomGroup_RoomGroupId");

            entity.HasIndex(e => e.UserId, "IX_UserRoomGroup_UserId");

            entity.HasOne(d => d.RoomGroup).WithMany()
                .HasForeignKey(d => d.RoomGroupId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.User).WithMany().HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<UserRoomGroupType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UserRoomGroupType");

            entity.HasIndex(e => e.RgtypeId, "IX_UserRoomGroupType_RGTypeId");

            entity.HasIndex(e => e.UserId, "IX_UserRoomGroupType_UserId");

            entity.Property(e => e.RgtypeId).HasColumnName("RGTypeId");

            entity.HasOne(d => d.Rgtype).WithMany()
                .HasForeignKey(d => d.RgtypeId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.User).WithMany().HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Utsav>(entity =>
        {
            entity.ToTable("Utsav");

            entity.HasIndex(e => e.CreatedAt, "IX_Utsav_CreatedAt");

            entity.HasIndex(e => e.CreatedById, "IX_Utsav_CreatedById");

            entity.HasIndex(e => e.DefaultArrivalAt, "IX_Utsav_DefaultArrivalAt");

            entity.HasIndex(e => e.DefaultDepartureAt, "IX_Utsav_DefaultDepartureAt");

            entity.HasIndex(e => e.EndsOn, "IX_Utsav_EndsOn");

            entity.HasIndex(e => e.ModifiedAt, "IX_Utsav_ModifiedAt");

            entity.HasIndex(e => e.ModifiedById, "IX_Utsav_ModifiedById");

            entity.HasIndex(e => e.StartsOn, "IX_Utsav_StartsOn");

            entity.HasIndex(e => e.UniqueId, "IX_Utsav_UniqueId").IsUnique();

            entity.Property(e => e.Lat).HasColumnType("DECIMAL(12, 8)");
            entity.Property(e => e.Long).HasColumnType("DECIMAL(12, 8)");

            entity.HasOne(d => d.CreatedBy).WithMany(p => p.UtsavCreatedBies)
                .HasForeignKey(d => d.CreatedById)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ModifiedBy).WithMany(p => p.UtsavModifiedBies)
                .HasForeignKey(d => d.ModifiedById)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<WebAccReq>(entity =>
        {
            entity.ToTable("WebAccReq");

            entity.HasIndex(e => e.DownloadedAt, "IX_WebAccReq_DownloadedAt");

            entity.HasIndex(e => e.ImportedAt, "IX_WebAccReq_ImportedAt");

            entity.HasIndex(e => e.RequestedAt, "IX_WebAccReq_RequestedAt");

            entity.HasIndex(e => e.UtsavId, "IX_WebAccReq_UtsavId");

            entity.HasIndex(e => e.WebReqId, "IX_WebAccReq_WebReqId").IsUnique();

            entity.HasOne(d => d.Utsav).WithMany(p => p.WebAccReqs)
                .HasForeignKey(d => d.UtsavId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<WebAccReqDetail>(entity =>
        {
            entity.ToTable("WebAccReqDetail");

            entity.HasIndex(e => e.WebAccReqId, "IX_WebAccReqDetail_WebAccReqId");

            entity.HasOne(d => d.WebAccReq).WithMany(p => p.WebAccReqDetails)
                .HasForeignKey(d => d.WebAccReqId)
                .OnDelete(DeleteBehavior.Restrict);
        });

/*        OnModelCreatingPartial(modelBuilder);
*/    }
/*    public void OnModelCreatingPartial(ModelBuilder modelBuilder);
*/    public virtual DbSet<AccDetail> AccDetails { get; set; }

    public virtual DbSet<AccReq> AccReqs { get; set; }

    public virtual DbSet<AccReqDetail> AccReqDetails { get; set; }

    public virtual DbSet<AccReqStatus> AccReqStatuses { get; set; }

    public virtual DbSet<AccReqToken> AccReqTokens { get; set; }

    public virtual DbSet<Aitype> Aitypes { get; set; }

    public virtual DbSet<Amenity> Amenities { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<ContactPhone> ContactPhones { get; set; }

    public virtual DbSet<ContactType> ContactTypes { get; set; }

    public virtual DbSet<Continent> Continents { get; set; }

    public virtual DbSet<Counter> Counters { get; set; }

    public virtual DbSet<CounterRoomGroup> CounterRoomGroups { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<DataProtectionKey> DataProtectionKeys { get; set; }

    public virtual DbSet<DeviceCode> DeviceCodes { get; set; }

    public virtual DbSet<Floor> Floors { get; set; }

    public virtual DbSet<Haribhakt> Haribhakts { get; set; }

    public virtual DbSet<House> Houses { get; set; }

    public virtual DbSet<HouseAmenity> HouseAmenities { get; set; }

    public virtual DbSet<HouseContact> HouseContacts { get; set; }

    public virtual DbSet<HouseInventory> HouseInventories { get; set; }

    public virtual DbSet<HouseType> HouseTypes { get; set; }

    public virtual DbSet<Image> Images { get; set; }

    public virtual DbSet<ImageType> ImageTypes { get; set; }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<Key> Keys { get; set; }

    public virtual DbSet<MaintenanceIssue> MaintenanceIssues { get; set; }

    public virtual DbSet<MemCache> MemCaches { get; set; }

    public virtual DbSet<PersistedGrant> PersistedGrants { get; set; }

    public virtual DbSet<PreAllotment> PreAllotments { get; set; }

    public virtual DbSet<PreAllotmentDetail> PreAllotmentDetails { get; set; }

    public virtual DbSet<QueryRoomGroup> QueryRoomGroups { get; set; }

    public virtual DbSet<Relation> Relations { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<ReqTransMode> ReqTransModes { get; set; }

    public virtual DbSet<RequestMode> RequestModes { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<RoomAmenity> RoomAmenities { get; set; }

    public virtual DbSet<RoomCleaningStatus> RoomCleaningStatuses { get; set; }

    public virtual DbSet<RoomGroup> RoomGroups { get; set; }

    public virtual DbSet<RoomGroupAmenity> RoomGroupAmenities { get; set; }

    public virtual DbSet<RoomGroupContact> RoomGroupContacts { get; set; }

    public virtual DbSet<RoomGroupType> RoomGroupTypes { get; set; }

    public virtual DbSet<RoomInventory> RoomInventories { get; set; }

    public virtual DbSet<RoomStatus> RoomStatuses { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<UserRoomGroup> UserRoomGroups { get; set; }

    public virtual DbSet<UserRoomGroupType> UserRoomGroupTypes { get; set; }

    public virtual DbSet<Utsav> Utsavs { get; set; }

    public virtual DbSet<WebAccReq> WebAccReqs { get; set; }

    public virtual DbSet<WebAccReqDetail> WebAccReqDetails { get; set; }
}
