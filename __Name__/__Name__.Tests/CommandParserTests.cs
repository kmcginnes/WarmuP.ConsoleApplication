using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace __Name__.Tests
{
    public class CommandParserTests
    {
        private readonly CommandParser _sut = new CommandParser();

        [Fact]
        public void when_parsing_foo_it_should_find_nothing()
        {
            var args = new[] {"foo"};

            var result = _sut.Parse(args);

            result.Should().NotBeNull();
            result.Should().BeEmpty();
        }
    }

    public class CommandParser
    {
        public IEnumerable<IConsoleCommand> Parse(string[] args)
        {
            return Enumerable.Empty<IConsoleCommand>();
        }
    }

    public interface IConsoleCommand
    {
    }
}
