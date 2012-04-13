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
namespace Conference.Specflow.Features.Registration.AllFeaturesEndToEnd
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class RegistrantWorkflowForRegisteringAGroupOfAttendeesForAConferenceSadPathFeature : Xunit.IUseFixture<RegistrantWorkflowForRegisteringAGroupOfAttendeesForAConferenceSadPathFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GroupRegistrationEndToEndSad.feature"
#line hidden
        
        public RegistrantWorkflowForRegisteringAGroupOfAttendeesForAConferenceSadPathFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Registrant workflow for registering a group of Attendees for a conference (sad pa" +
                    "th)", "In order to register for conference a group of Attendees\r\nAs a Registrant\r\nI want" +
                    " to be able to select Order Items from one or many available Order Items and mak" +
                    "e a Reservation", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void SetFixture(RegistrantWorkflowForRegisteringAGroupOfAttendeesForAConferenceSadPathFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Registrant workflow for registering a group of Attendees for a conference (sad pa" +
            "th)")]
        [Xunit.TraitAttribute("Description", "All the Order Items are available, then some get waitlisted and some reserved")]
        public virtual void AllTheOrderItemsAreAvailableThenSomeGetWaitlistedAndSomeReserved()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("All the Order Items are available, then some get waitlisted and some reserved", ((string[])(null)));
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
                        "2"});
            table2.AddRow(new string[] {
                        "Additional cocktail party",
                        "2"});
#line 18
 testRunner.Given("the selected available Order Items", ((string)(null)), table2);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type"});
            table3.AddRow(new string[] {
                        "General admission"});
#line 22
 testRunner.And("these Seat Types becomes unavailable before the Registrant make the reservation", ((string)(null)), table3);
#line 25
 testRunner.When("the Registrant proceed to make the Reservation");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table4.AddRow(new string[] {
                        "General admission",
                        "1"});
#line 26
 testRunner.Then("the Registrant is offered to be waitlisted for these Order Items", ((string)(null)), table4);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table5.AddRow(new string[] {
                        "General admission",
                        "1"});
            table5.AddRow(new string[] {
                        "Additional cocktail party",
                        "2"});
#line 29
 testRunner.And("These other Order Items get reserved", ((string)(null)), table5);
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Registrant workflow for registering a group of Attendees for a conference (sad pa" +
            "th)")]
        [Xunit.TraitAttribute("Description", "Checkout:Registrant Invalid Details")]
        public virtual void CheckoutRegistrantInvalidDetails()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Checkout:Registrant Invalid Details", ((string[])(null)));
#line 35
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "First name",
                        "Last name",
                        "email address",
                        "Seat type"});
            table6.AddRow(new string[] {
                        "William",
                        "",
                        "William@Smith.com",
                        "General admission"});
            table6.AddRow(new string[] {
                        "Mani",
                        "Kris",
                        "Mani@Kris.com",
                        "Additional cocktail party"});
            table6.AddRow(new string[] {
                        "Jim",
                        "John",
                        "Jim@John.com",
                        "Additional cocktail party"});
#line 36
 testRunner.Given("the Registrant enter these details", ((string)(null)), table6);
#line 41
 testRunner.And("the Last name is empty");
#line 43
 testRunner.When("the Registrant proceed to select a payment option");
#line 44
 testRunner.Then("the invalid field is highlighted with a hint of the error cause");
#line 45
 testRunner.And("the countdown has decreased within the allowed timeslot for holding the Reservati" +
                    "on");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Registrant workflow for registering a group of Attendees for a conference (sad pa" +
            "th)")]
        [Xunit.TraitAttribute("Description", "Checkout:Payment with cancellation")]
        public virtual void CheckoutPaymentWithCancellation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Checkout:Payment with cancellation", ((string[])(null)));
#line 48
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "First name",
                        "Last name",
                        "email address",
                        "Seat type"});
            table7.AddRow(new string[] {
                        "William",
                        "Smith",
                        "William@Smith.com",
                        "General admission"});
            table7.AddRow(new string[] {
                        "Mani",
                        "Kris",
                        "Mani@Kris.com",
                        "Additional cocktail party"});
            table7.AddRow(new string[] {
                        "Jim",
                        "John",
                        "Jim@John.com",
                        "Additional cocktail party"});
#line 49
 testRunner.Given("the Registrant enter these details", ((string)(null)), table7);
#line 54
 testRunner.And("the countdown has decreased within the allowed timeslot for holding the Reservati" +
                    "on");
#line 55
 testRunner.And("the Registrant select one of the offered payment options");
#line 56
 testRunner.When("the Registrant decides to cancel the payment");
#line 57
    testRunner.Then("a cancelation message will be shown to the Registrant and will get back to the pa" +
                    "yment options");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Registrant workflow for registering a group of Attendees for a conference (sad pa" +
            "th)")]
        [Xunit.TraitAttribute("Description", "Checkout:Partial Payment and place Order")]
        public virtual void CheckoutPartialPaymentAndPlaceOrder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Checkout:Partial Payment and place Order", ((string[])(null)));
#line 60
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Mani",
                        "Kris",
                        "Mani@Kris.com",
                        "Additional cocktail party"});
            table8.AddRow(new string[] {
                        "William",
                        "Smith",
                        "William@Smith.com",
                        "General admission"});
            table8.AddRow(new string[] {
                        "Mani",
                        "Kris",
                        "Mani@Kris.com",
                        "Additional cocktail party"});
#line 61
 testRunner.Given("the Registrant enter these details", ((string)(null)), table8);
#line 65
 testRunner.And("the countdown has decreased within the allowed timeslot for holding the Reservati" +
                    "on");
#line 66
 testRunner.And("the Registrant select one of the offered payment options");
#line 67
 testRunner.When("the Registrant proceed to confirm the payment");
#line 68
    testRunner.Then("a receipt will be received from the payment provider indicating success with some" +
                    " transaction id");
#line 69
 testRunner.And("a Registration confirmation with the Access code should be displayed");
#line 70
 testRunner.And("an email with the Access Code will be send to the registered email.");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Registrant workflow for registering a group of Attendees for a conference (sad pa" +
            "th)")]
        [Xunit.TraitAttribute("Description", "Allocate some purchased Seats for a group")]
        public virtual void AllocateSomePurchasedSeatsForAGroup()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Allocate some purchased Seats for a group", ((string[])(null)));
#line 73
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 74
testRunner.Given("the ConfirmSuccessfulRegistration");
#line 75
testRunner.And("the order access code is 6789");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "First name",
                        "Last name",
                        "email address",
                        "Seat type"});
            table9.AddRow(new string[] {
                        "William",
                        "Smith",
                        "William@Smith.com",
                        "General admission"});
#line 76
testRunner.And("the Registrant assign the group purchased Seats to attendees as following", ((string)(null)), table9);
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "First name",
                        "Last name",
                        "email address",
                        "Seat type"});
            table10.AddRow(new string[] {
                        "Mani",
                        "Kris",
                        "Mani@Kris.com",
                        "Additional cocktail party"});
#line 79
testRunner.And("leave unassigned these individual purchased seats", ((string)(null)), table10);
#line 82
testRunner.Then("the Registrant should get a Seat Assignment confirmation");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Access code",
                        "email address",
                        "Seat type"});
            table11.AddRow(new string[] {
                        "6789-1",
                        "William@Smith.com",
                        "General admission"});
#line 83
testRunner.And("the Attendees should get an email informing about the conference and the Seat Typ" +
                    "e with Seat Access Code", ((string)(null)), table11);
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                RegistrantWorkflowForRegisteringAGroupOfAttendeesForAConferenceSadPathFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                RegistrantWorkflowForRegisteringAGroupOfAttendeesForAConferenceSadPathFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
