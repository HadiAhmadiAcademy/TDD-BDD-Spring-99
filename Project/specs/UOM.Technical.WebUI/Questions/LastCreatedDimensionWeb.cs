using System;
using Suzianna.Core.Screenplay.Actors;
using UOM.Specs.Shared.Models;
using UOM.Specs.Shared.Questions;

namespace UOM.Technical.WebUI.Questions
{
    public class LastCreatedDimensionWeb : LastCreatedDimension
    {
        public override MeasurementDimension Execute(long id, Actor actor)
        {
            throw new NotImplementedException();
        }
    }
}