using System;
using System.Collections.Generic;
using FluentAssertions;
using RestSharp;
using RestSharp.Authenticators;
using Suzianna.Core.Screenplay;
using Suzianna.Core.Screenplay.Actors;
using Suzianna.Rest.Screenplay.Abilities;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using UOM.Specs.Constants;
using UOM.Specs.Screenplay;
using UOM.Specs.Screenplay.Tasks;
using UOM.Specs.Shared.Models;
using UOM.Specs.Shared.Questions;

namespace UOM.Specs.Steps
{
    [Binding]
    public class MeasurementDimensionsSteps
    {
        private MeasurementDimension _dimension;
        private Stage _stage;
        public MeasurementDimensionsSteps(Stage stage)
        {
            _stage = stage;
        }

        [Given(@"I have entered as procurement manager account")]
        public void GivenIHaveEnteredAsProcurementManagerAccount()
        {
            _stage.ShineSpotlightOn("Procurement Manager");
        }

        [When(@"I define the following dimension")]
        public void WhenIDefineTheFollowingDimension(Table table)
        {
            _dimension = table.CreateInstance<MeasurementDimension>();
            _stage.ActorInTheSpotlight.AttemptsTo(Define.Dimension(_dimension));
        }

        [Then(@"I should be able to see the dimension in the list of dimensions")]
        public void ThenIShouldBeAbleToSeeTheDimensionInTheListOfDimensions()
        {
            //var actualDimension = _stage.ActorInTheSpotlight.AsksFor(new LastCreatedDimension());
            //actualDimension.Should().BeEquivalentTo(_dimension);
        }
    }
}
