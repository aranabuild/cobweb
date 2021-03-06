using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using Cobweb.Testing.Mvc.Assertions;
using Cobweb.Testing.Mvc.Tests.TestableTypes;
using NUnit.Framework;

namespace Cobweb.Testing.Mvc.Tests.Routing.GivenDefaultRoute {
    [TestFixture]
    public class WithControllerInNameControllerDefaultActionExpression : GivenDefaultRoute {
        private readonly Expression<Func<HasControllerInNameController, ActionResult>> _currentExpression =
            controller => controller.Index();

        [Test]
        public void ItShouldMapExpressionToControllerUrl() {
            _currentExpression.Should().MapToUrl("/HasControllerInName");
        }
    }
}
