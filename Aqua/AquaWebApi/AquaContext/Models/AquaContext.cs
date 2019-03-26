using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using AquaContext.Mapping;

namespace AquaContext
{
    public partial class AquaContext : DbContext
    {
        static AquaContext()
        {
            Database.SetInitializer<AquaContext>(null);
        }

        public AquaContext()
            : base("Name=AquaContext")
        {
        }

        public DbSet<AccountGroupMaster> AccountGroupMasters { get; set; }
        public DbSet<AccountMaster> AccountMasters { get; set; }
        public DbSet<AccountTypeMaster> AccountTypeMasters { get; set; }
        public DbSet<BookingDetail> BookingDetails { get; set; }
        public DbSet<BookingJournalMapping> BookingJournalMappings { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<CanStockHistory> CanStockHistories { get; set; }
        public DbSet<CanStock> CanStocks { get; set; }
        public DbSet<DealerMaster> DealerMasters { get; set; }
        public DbSet<DealerRateMapping> DealerRateMappings { get; set; }
        public DbSet<DepartmentMaster> DepartmentMasters { get; set; }
        public DbSet<JournalHistory> JournalHistories { get; set; }
        public DbSet<Journal> Journals { get; set; }
        public DbSet<ModuleReference> ModuleReferences { get; set; }
        public DbSet<ProductMaster> ProductMasters { get; set; }
        public DbSet<ProductStockDeclaration> ProductStockDeclarations { get; set; }
        public DbSet<ProductStockDeclarationDetail> ProductStockDeclarationDetails { get; set; }
        public DbSet<ProductStockDeclarationDetailsHistory> ProductStockDeclarationDetailsHistories { get; set; }
        public DbSet<ProductStockDeclarationHistory> ProductStockDeclarationHistories { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public DbSet<RawMaterialMaster> RawMaterialMasters { get; set; }
        public DbSet<SalaryDeclaration> SalaryDeclarations { get; set; }
        public DbSet<SalaryDeclarationHistory> SalaryDeclarationHistories { get; set; }
        public DbSet<SalaryPaymentHistory> SalaryPaymentHistories { get; set; }
        public DbSet<SalaryPayment> SalaryPayments { get; set; }
        public DbSet<StockDeclaration> StockDeclarations { get; set; }
        public DbSet<StockDeclarationDetail> StockDeclarationDetails { get; set; }
        public DbSet<StockDeclarationDetailsHistory> StockDeclarationDetailsHistories { get; set; }
        public DbSet<StockDeclarationHistory> StockDeclarationHistories { get; set; }
        public DbSet<StoreInwardDetailHistory> StoreInwardDetailHistories { get; set; }
        public DbSet<StoreInwardDetail> StoreInwardDetails { get; set; }
        public DbSet<StoreInwardHistory> StoreInwardHistories { get; set; }
        public DbSet<StoreInwardJournalMapping> StoreInwardJournalMappings { get; set; }
        public DbSet<StoreInward> StoreInwards { get; set; }
        public DbSet<SupplierMaster> SupplierMasters { get; set; }
        public DbSet<SupplierRawMaterialMapping> SupplierRawMaterialMappings { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<UserMaster> UserMasters { get; set; }
        public DbSet<UserModuleEntitlementMapping> UserModuleEntitlementMappings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountGroupMasterMap());
            modelBuilder.Configurations.Add(new AccountMasterMap());
            modelBuilder.Configurations.Add(new AccountTypeMasterMap());
            modelBuilder.Configurations.Add(new BookingDetailMap());
            modelBuilder.Configurations.Add(new BookingJournalMappingMap());
            modelBuilder.Configurations.Add(new BookingMap());
            modelBuilder.Configurations.Add(new CanStockHistoryMap());
            modelBuilder.Configurations.Add(new CanStockMap());
            modelBuilder.Configurations.Add(new DealerMasterMap());
            modelBuilder.Configurations.Add(new DealerRateMappingMap());
            modelBuilder.Configurations.Add(new DepartmentMasterMap());
            modelBuilder.Configurations.Add(new JournalHistoryMap());
            modelBuilder.Configurations.Add(new JournalMap());
            modelBuilder.Configurations.Add(new ModuleReferenceMap());
            modelBuilder.Configurations.Add(new ProductMasterMap());
            modelBuilder.Configurations.Add(new ProductStockDeclarationMap());
            modelBuilder.Configurations.Add(new ProductStockDeclarationDetailMap());
            modelBuilder.Configurations.Add(new ProductStockDeclarationDetailsHistoryMap());
            modelBuilder.Configurations.Add(new ProductStockDeclarationHistoryMap());
            modelBuilder.Configurations.Add(new PurchaseOrderMap());
            modelBuilder.Configurations.Add(new PurchaseOrderDetailMap());
            modelBuilder.Configurations.Add(new RawMaterialMasterMap());
            modelBuilder.Configurations.Add(new SalaryDeclarationMap());
            modelBuilder.Configurations.Add(new SalaryDeclarationHistoryMap());
            modelBuilder.Configurations.Add(new SalaryPaymentHistoryMap());
            modelBuilder.Configurations.Add(new SalaryPaymentMap());
            modelBuilder.Configurations.Add(new StockDeclarationMap());
            modelBuilder.Configurations.Add(new StockDeclarationDetailMap());
            modelBuilder.Configurations.Add(new StockDeclarationDetailsHistoryMap());
            modelBuilder.Configurations.Add(new StockDeclarationHistoryMap());
            modelBuilder.Configurations.Add(new StoreInwardDetailHistoryMap());
            modelBuilder.Configurations.Add(new StoreInwardDetailMap());
            modelBuilder.Configurations.Add(new StoreInwardHistoryMap());
            modelBuilder.Configurations.Add(new StoreInwardJournalMappingMap());
            modelBuilder.Configurations.Add(new StoreInwardMap());
            modelBuilder.Configurations.Add(new SupplierMasterMap());
            modelBuilder.Configurations.Add(new SupplierRawMaterialMappingMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new UserMasterMap());
            modelBuilder.Configurations.Add(new UserModuleEntitlementMappingMap());
        }
    }
}
