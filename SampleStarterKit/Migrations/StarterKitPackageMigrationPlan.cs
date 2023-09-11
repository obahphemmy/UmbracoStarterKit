using SampleStarterKit.Migrations;
using System;
using Umbraco.Cms.Core.Packaging;
using Umbraco.Cms.Infrastructure.Packaging;

namespace SampleStarterKit.Migrations
{
    public class StarterKitPackageMigrationPlan : PackageMigrationPlan
    {
        public StarterKitPackageMigrationPlan()
            : base("SampleStarterKit")
        {
        }

        protected override void DefinePlan()
        {
            To<ImportPackageXmlMigration>(new Guid("087C5260-895E-4D64-8FA9-D24942769140"));
        }
    }
}