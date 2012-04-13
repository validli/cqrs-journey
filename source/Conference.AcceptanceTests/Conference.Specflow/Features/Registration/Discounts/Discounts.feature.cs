﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Conference.Specflow.Features.Registration.Discounts
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class PromotionalCodeScenariosForApplyingPromotionalCodesToSeatTypesFeature : Xunit.IUseFixture<PromotionalCodeScenariosForApplyingPromotionalCodesToSeatTypesFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Discounts.feature"
#line hidden
        
        public PromotionalCodeScenariosForApplyingPromotionalCodesToSeatTypesFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Promotional Code scenarios for applying Promotional Codes to Seat Types", "In order to apply a Promotional Code for one ore more Seat Types\r\nAs a Registrant" +
                    "\r\nI want to be able to enter a Promotional Code and get the specified price redu" +
                    "ction", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "rate"});
            table1.AddRow(new string[] {
                        "General admission",
                        "$199"});
            table1.AddRow(new string[] {
                        "Pre-con Workshop with Greg Young",
                        "$500"});
            table1.AddRow(new string[] {
                        "Additional cocktail party",
                        "$50"});
#line 7
 testRunner.Given("the list of the available Order Items for the CQRS summit 2012 conference", ((string)(null)), table1);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Promotional Code",
                        "Discount",
                        "Quota",
                        "Scope",
                        "Cumulative"});
            table2.AddRow(new string[] {
                        "SPEAKER123",
                        "100%",
                        "Unlimited",
                        "All",
                        ""});
            table2.AddRow(new string[] {
                        "VOLUNTEER",
                        "100%",
                        "Unlimited",
                        "General admission",
                        ""});
            table2.AddRow(new string[] {
                        "COPRESENTER",
                        "10%",
                        "Unlimited",
                        "Additional cocktail party",
                        "Exclusive"});
            table2.AddRow(new string[] {
                        "WS10",
                        "$20",
                        "Unlimited",
                        "All",
                        "VOLUNTEER"});
            table2.AddRow(new string[] {
                        "1TIMEPRECON",
                        "50%",
                        "Single",
                        "Pre-con Workshop with Greg Young",
                        ""});
            table2.AddRow(new string[] {
                        "CONFONLY",
                        "$50",
                        "Single",
                        "General admission, Pre-con Workshop with Greg Young",
                        ""});
#line 12
 testRunner.And("the Promotional Codes", ((string)(null)), table2);
#line hidden
        }
        
        public virtual void SetFixture(PromotionalCodeScenariosForApplyingPromotionalCodesToSeatTypesFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Promotional Code scenarios for applying Promotional Codes to Seat Types")]
        [Xunit.TraitAttribute("Description", "Full Promotional Code for all selected items")]
        public virtual void FullPromotionalCodeForAllSelectedItems()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Full Promotional Code for all selected items", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table3.AddRow(new string[] {
                        "General admission",
                        "3"});
            table3.AddRow(new string[] {
                        "Pre-con Workshop with Greg Young",
                        "1"});
            table3.AddRow(new string[] {
                        "Additional cocktail party",
                        "2"});
#line 23
 testRunner.Given("the selected available Order Items", ((string)(null)), table3);
#line 28
 testRunner.And("the total amount should be of $1197");
#line 29
 testRunner.When("the Registrant apply the \'SPEAKER123\' Promotional Code");
#line 30
 testRunner.Then("the \'SPEAKER123\' Coupon item should show a value of -$1197");
#line 31
 testRunner.And("the total amount should be of $0");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Promotional Code scenarios for applying Promotional Codes to Seat Types")]
        [Xunit.TraitAttribute("Description", "Partial Promotional Code for all selected items")]
        public virtual void PartialPromotionalCodeForAllSelectedItems()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Partial Promotional Code for all selected items", ((string[])(null)));
#line 34
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table4.AddRow(new string[] {
                        "General admission",
                        "3"});
            table4.AddRow(new string[] {
                        "Pre-con Workshop with Greg Young",
                        "1"});
            table4.AddRow(new string[] {
                        "Additional cocktail party",
                        "2"});
#line 35
 testRunner.Given("the selected available Order Items", ((string)(null)), table4);
#line 40
 testRunner.And("the total amount should be of $1197");
#line 41
 testRunner.When("the Registrant apply the \'VOLUNTEER\' Promotional Code");
#line 42
 testRunner.Then("the \'VOLUNTEER\' Coupon item should show a value of -$597");
#line 43
 testRunner.And("the total amount should be of $600");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Promotional Code scenarios for applying Promotional Codes to Seat Types")]
        [Xunit.TraitAttribute("Description", "Partial Promotional Code for none of the selected items")]
        public virtual void PartialPromotionalCodeForNoneOfTheSelectedItems()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Partial Promotional Code for none of the selected items", ((string[])(null)));
#line 46
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table5.AddRow(new string[] {
                        "Pre-con Workshop with Greg Young",
                        "1"});
            table5.AddRow(new string[] {
                        "Additional cocktail party",
                        "2"});
#line 47
 testRunner.Given("the selected available Order Items", ((string)(null)), table5);
#line 51
 testRunner.And("the total amount should be of $600");
#line 52
 testRunner.When("the Registrant apply the \'VOLUNTEER\' Promotional Code");
#line 53
 testRunner.Then("the \'VOLUNTEER\' Coupon will not be applied and an error message will inform about" +
                    " the problem");
#line 54
 testRunner.And("the total amount should be of $600");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Promotional Code scenarios for applying Promotional Codes to Seat Types")]
        [Xunit.TraitAttribute("Description", "Cumulative Promotional Codes")]
        public virtual void CumulativePromotionalCodes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cumulative Promotional Codes", ((string[])(null)));
#line 57
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table6.AddRow(new string[] {
                        "General admission",
                        "3"});
            table6.AddRow(new string[] {
                        "Pre-con Workshop with Greg Young",
                        "1"});
            table6.AddRow(new string[] {
                        "Additional cocktail party",
                        "2"});
#line 58
 testRunner.Given("the selected available Order Items", ((string)(null)), table6);
#line 63
 testRunner.And("the total amount should be of $1197");
#line 64
 testRunner.When("the Registrant apply the \'COPRESENTER\' Promotional Code");
#line 65
 testRunner.And("the Registrant apply the \'WS10\' Promotional Code");
#line 66
 testRunner.Then("the \'COPRESENTER\' Promotional Code item should show a value of -$10");
#line 67
 testRunner.And("the \'WS10\' Promotional Code item should show a value of -$20");
#line 68
 testRunner.And("the total amount should be of $1167");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Promotional Code scenarios for applying Promotional Codes to Seat Types")]
        [Xunit.TraitAttribute("Description", "Single use Promotional Code")]
        public virtual void SingleUsePromotionalCode()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Single use Promotional Code", ((string[])(null)));
#line 71
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table7.AddRow(new string[] {
                        "Pre-con Workshop with Greg Young",
                        "1"});
            table7.AddRow(new string[] {
                        "Additional cocktail party",
                        "2"});
#line 72
 testRunner.Given("the selected available Order Items", ((string)(null)), table7);
#line 76
 testRunner.And("the total amount should be of $600");
#line 77
 testRunner.And("the Registrant apply the \'1TIMEPRECON\' Promotional Code");
#line 78
 testRunner.And("the total amount should be of $350");
#line 79
 testRunner.And("the Registrant proceed to complete the registration");
#line 80
 testRunner.And("the Registrant selects the Event Registration");
#line 81
 testRunner.When("the Registrant apply the \'1TIMEPRECON\' Promotional Code");
#line 82
 testRunner.Then("the \'1TIMEPRECON\' Coupon will not be applied and an error message will inform abo" +
                    "ut the problem");
#line 83
 testRunner.And("the total amount should be of $600");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Promotional Code scenarios for applying Promotional Codes to Seat Types")]
        [Xunit.TraitAttribute("Description", "Mutually exclusive Promotional Code")]
        public virtual void MutuallyExclusivePromotionalCode()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Mutually exclusive Promotional Code", ((string[])(null)));
#line 86
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table8.AddRow(new string[] {
                        "General admission",
                        "3"});
            table8.AddRow(new string[] {
                        "Pre-con Workshop with Greg Young",
                        "1"});
            table8.AddRow(new string[] {
                        "Additional cocktail party",
                        "2"});
#line 87
 testRunner.Given("the selected available Order Items", ((string)(null)), table8);
#line 92
 testRunner.And("the total amount should be of $1197");
#line 93
 testRunner.When("the Registrant apply the \'COPRESENTER\' Promotional Code");
#line 94
 testRunner.And("the Registrant apply the \'VOLUNTEER\' Promotional Code");
#line 95
 testRunner.Then("the \'VOLUNTEER\' Coupon will not be applied and an error message will inform about" +
                    " the problem");
#line 96
 testRunner.And("the \'COPRESENTER\' Promotional Code item should show a value of -$10");
#line 97
 testRunner.And("the total amount should be of $1187");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Promotional Code scenarios for applying Promotional Codes to Seat Types")]
        [Xunit.TraitAttribute("Description", "Combine only Promotional Code")]
        public virtual void CombineOnlyPromotionalCode()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Combine only Promotional Code", ((string[])(null)));
#line 100
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table9.AddRow(new string[] {
                        "General admission",
                        "3"});
            table9.AddRow(new string[] {
                        "Pre-con Workshop with Greg Young",
                        "1"});
            table9.AddRow(new string[] {
                        "Additional cocktail party",
                        "2"});
#line 101
 testRunner.Given("the selected available Order Items", ((string)(null)), table9);
#line 106
 testRunner.And("the total amount should be of $1197");
#line 107
 testRunner.When("the Registrant apply the \'WS10\' Promotional Code");
#line 108
 testRunner.And("the Registrant apply the \'VOLUNTEER\' Promotional Code");
#line 109
 testRunner.Then("the \'VOLUNTEER\' Coupon item should show a value of -$597");
#line 110
 testRunner.And("the \'WS10\' Promotional Code item should show a value of -$10");
#line 111
 testRunner.And("the total amount should be of $590");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Promotional Code scenarios for applying Promotional Codes to Seat Types")]
        [Xunit.TraitAttribute("Description", "Partial scope")]
        public virtual void PartialScope()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Partial scope", ((string[])(null)));
#line 114
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table10.AddRow(new string[] {
                        "General admission",
                        "1"});
            table10.AddRow(new string[] {
                        "Pre-con Workshop with Greg Young",
                        "1"});
            table10.AddRow(new string[] {
                        "Additional cocktail party",
                        "1"});
#line 115
 testRunner.Given("the selected available Order Items", ((string)(null)), table10);
#line 120
 testRunner.And("the total amount should be of $749");
#line 121
 testRunner.When("the Registrant apply the \'CONFONLY\' Promotional Code");
#line 122
 testRunner.Then("the \'CONFONLY\' Coupon item should show a value of -$50");
#line 123
 testRunner.And("the total amount should be of $699");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                PromotionalCodeScenariosForApplyingPromotionalCodesToSeatTypesFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PromotionalCodeScenariosForApplyingPromotionalCodesToSeatTypesFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
