using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Monolith.Planets.Shared;

namespace Monolith.Planets.Controllers {

    [Route("planets")]
    public class PlanetsController : ControllerBase {
        private readonly IsPlanetProvider _service;

        public PlanetsController(IsPlanetProvider service) {
            _service = service;
        }

        public IEnumerable<Planet> Get() {
            return _service.Get();
        }
    }
}