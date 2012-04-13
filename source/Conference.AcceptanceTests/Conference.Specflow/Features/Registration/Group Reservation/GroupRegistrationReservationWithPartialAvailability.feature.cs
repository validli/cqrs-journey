﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:2.0.50727.5448
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Conference.Specflow.Features.Registration.GroupReservation
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class RegistrantScenariosForRegisteringAGroupOfAttendeesForAConferenceWhenFewSeatsAreAvailableInAllTheSeatTypesFeature : Xunit.IUseFixture<RegistrantScenariosForRegisteringAGroupOfAttendeesForAConferenceWhenFewSeatsAreAvailableInAllTheSeatTypesFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GroupRegistrationReservationWithPartialAvailability.feature"
#line hidden
        
        public RegistrantScenariosForRegisteringAGroupOfAttendeesForAConferenceWhenFewSeatsAreAvailableInAllTheSeatTypesFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Registrant scenarios for registering a group of Attendees for a conference when f" +
                    "ew Seats are available in all the Seat Types", "In order to register for conference a group of Attendees\r\nAs a Registrant\r\n  I wa" +
                    "nt to be able to select Order Items from one or many of the available and or wai" +
                    "tlisted Order Items and make a Reservation", ProgrammingLanguage.CSharp, ((string[])(null)));
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
#line 7
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
#line 8
 testRunner.Given("the list of the available Order Items for the CQRS summit 2012 conference", ((string)(null)), table1);
#line hidden
        }
        
        public virtual void SetFixture(RegistrantScenariosForRegisteringAGroupOfAttendeesForAConferenceWhenFewSeatsAreAvailableInAllTheSeatTypesFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Registrant scenarios for registering a group of Attendees for a conference when f" +
            "ew Seats are available in all the Seat Types")]
        [Xunit.TraitAttribute("Description", "All the Order Items are offered to be waitlisted and all are selected, then all g" +
            "et confirmed")]
        public virtual void AllTheOrderItemsAreOfferedToBeWaitlistedAndAllAreSelectedThenAllGetConfirmed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("All the Order Items are offered to be waitlisted and all are selected, then all g" +
                    "et confirmed", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table2.AddRow(new string[] {
                        "General admission",
                        "3"});
            table2.AddRow(new string[] {
                        "Pre-con Workshop with Greg Young",
                        "1"});
            table2.AddRow(new string[] {
                        "Additional cocktail party",
                        "2"});
#line 18
 testRunner.Given("the list of Order Items offered to be waitlisted and selected by the Registrant", ((string)(null)), table2);
#line 23
 testRunner.When("the Registrant proceed to make the Reservation");
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
#line 24
 testRunner.Then("these Order Itmes get confirmed being waitlisted", ((string)(null)), table3);
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Registrant scenarios for registering a group of Attendees for a conference when f" +
            "ew Seats are available in all the Seat Types")]
        [Xunit.TraitAttribute("Description", "2 the Order Items are available and 1 waitlisted, 1 becomes partially available,")]
        public virtual void _2TheOrderItemsAreAvailableAnd1Waitlisted1BecomesPartiallyAvailable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("2 the Order Items are available and 1 waitlisted, 1 becomes partially available,", ((string[])(null)));
#line 33
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table4.AddRow(new string[] {
                        "General admission",
                        "7"});
            table4.AddRow(new string[] {
                        "Pre-con Workshop with Greg Young",
                        "2"});
#line 35
 testRunner.Given("the selected available Order Items", ((string)(null)), table4);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table5.AddRow(new string[] {
                        "Additional cocktail party",
                        "5"});
#line 39
 testRunner.And("the list of these Order Items offered to be waitlisted and selected by the Regist" +
                    "rant", ((string)(null)), table5);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type"});
            table6.AddRow(new string[] {
                        "General admission"});
#line 42
 testRunner.And("these Seat Types becomes partially unavailable before the Registrant make the res" +
                    "ervation", ((string)(null)), table6);
#line 45
 testRunner.When("the Registrant proceed to make the Reservation");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table7.AddRow(new string[] {
                        "General admission",
                        "3"});
            table7.AddRow(new string[] {
                        "Additional cocktail party",
                        "5"});
#line 46
 testRunner.Then("the Registrant is offered to be waitlisted for these Order Items", ((string)(null)), table7);
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table8.AddRow(new string[] {
                        "General admission",
                        "4"});
            table8.AddRow(new string[] {
                        "Pre-con Workshop with Greg Young",
                        "2"});
#line 50
 testRunner.And("These other Order Items get reserved", ((string)(null)), table8);
#line 54
 testRunner.And("the total amount should be of $1796");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                RegistrantScenariosForRegisteringAGroupOfAttendeesForAConferenceWhenFewSeatsAreAvailableInAllTheSeatTypesFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                RegistrantScenariosForRegisteringAGroupOfAttendeesForAConferenceWhenFewSeatsAreAvailableInAllTheSeatTypesFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
