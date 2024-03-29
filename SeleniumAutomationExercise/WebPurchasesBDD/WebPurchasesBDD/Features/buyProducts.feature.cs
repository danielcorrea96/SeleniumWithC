﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace WebPurchasesBDD.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class BuyProductsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "buyProducts.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "buyProducts", "I as a user of the application\r\nWant to purchases several products\r\nTo get the pr" +
                    "oducts i want", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "buyProducts")))
            {
                global::WebPurchasesBDD.Features.BuyProductsFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Purchase 10 items in the application with any product category")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "buyProducts")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("purchaseTenProducts")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("success")]
        public virtual void Purchase10ItemsInTheApplicationWithAnyProductCategory()
        {
            string[] tagsOfScenario = new string[] {
                    "purchaseTenProducts",
                    "success"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Purchase 10 items in the application with any product category", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 7
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
 testRunner.Given("the user tries to open the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "category",
                            "subcategory",
                            "brand",
                            "nameOfProduct"});
                table1.AddRow(new string[] {
                            "Women",
                            "Tops",
                            "Madame",
                            "Stylish Dress"});
                table1.AddRow(new string[] {
                            "Men",
                            "Jeans",
                            "H&M",
                            "Regular Fit Straight Jeans"});
                table1.AddRow(new string[] {
                            "Women",
                            "Dress",
                            "Madame",
                            "Sleeveless Dress"});
                table1.AddRow(new string[] {
                            "Women",
                            "Dress",
                            "Madame",
                            "Madame Top For Women"});
                table1.AddRow(new string[] {
                            "Kids",
                            "Dress",
                            "Kookie Kids",
                            "Full Sleeves Top Cherry - Pink"});
                table1.AddRow(new string[] {
                            "Kids",
                            "Dress",
                            "Kookie Kids",
                            "Little Girls Mr. Panda Shirt"});
                table1.AddRow(new string[] {
                            "Kids",
                            "Dress",
                            "Kookie Kids",
                            "Cotton Mull Embroidered Dress"});
                table1.AddRow(new string[] {
                            "Men",
                            "Tshirts",
                            "H&M",
                            "Men Tshirt"});
                table1.AddRow(new string[] {
                            "Women",
                            "Tops",
                            "Madame",
                            "Stylish Dress"});
                table1.AddRow(new string[] {
                            "Men",
                            "Tshirts",
                            "H&M",
                            "Pure Cotton V-Neck T-Shirt"});
#line 9
 testRunner.When("to purchase products", ((string)(null)), table1, "When ");
#line hidden
#line 21
 testRunner.Then("the user should see that 10 have been added to the cart with their total price", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
 testRunner.And("then he should delete from the added products to validate the empty cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Purchase non-existent item")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "buyProducts")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("alternativeFlow")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("failed")]
        public virtual void PurchaseNon_ExistentItem()
        {
            string[] tagsOfScenario = new string[] {
                    "alternativeFlow",
                    "failed"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Purchase non-existent item", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 25
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 26
 testRunner.Given("the user tries to open the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "category",
                            "subcategory",
                            "brand",
                            "nameOfProduct"});
                table2.AddRow(new string[] {
                            "Women",
                            "Dress",
                            "Madame",
                            "Non-existent"});
#line 27
 testRunner.When("to purchase products", ((string)(null)), table2, "When ");
#line hidden
#line 30
 testRunner.Then("the user should see that 6 have been added to the cart with their total price", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 31
 testRunner.And("then he should delete from the added products to validate the empty cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Purchase 5 items in the application with any product category but validate that t" +
            "here are 6 items in the cart")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "buyProducts")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("alternativeFlow")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("failed")]
        public virtual void Purchase5ItemsInTheApplicationWithAnyProductCategoryButValidateThatThereAre6ItemsInTheCart()
        {
            string[] tagsOfScenario = new string[] {
                    "alternativeFlow",
                    "failed"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Purchase 5 items in the application with any product category but validate that t" +
                    "here are 6 items in the cart", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 35
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 36
 testRunner.Given("the user tries to open the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "category",
                            "subcategory",
                            "brand",
                            "nameOfProduct"});
                table3.AddRow(new string[] {
                            "Women",
                            "Dress",
                            "Madame",
                            "Madame Top For Women"});
                table3.AddRow(new string[] {
                            "Kids",
                            "Dress",
                            "Kookie Kids",
                            "Full Sleeves Top Cherry - Pink"});
                table3.AddRow(new string[] {
                            "Kids",
                            "Dress",
                            "Kookie Kids",
                            "Little Girls Mr. Panda Shirt"});
                table3.AddRow(new string[] {
                            "Kids",
                            "Dress",
                            "Kookie Kids",
                            "Cotton Mull Embroidered Dress"});
                table3.AddRow(new string[] {
                            "Men",
                            "Tshirts",
                            "H&M",
                            "Men Tshirt"});
#line 37
 testRunner.When("to purchase products", ((string)(null)), table3, "When ");
#line hidden
#line 44
 testRunner.Then("the user should see that 6 have been added to the cart with their total price", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 45
 testRunner.And("then he should delete from the added products to validate the empty cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion