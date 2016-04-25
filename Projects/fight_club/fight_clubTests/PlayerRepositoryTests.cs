using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fight_club;


namespace fight_clubTests
{
    [TestFixture]
    class PlayerRepositoryTests
    {
        internal class TestContainer : IPlayersContainer
        {
            public List<Player> GetAll()
            {
                List<Player> list = new List<Player>();
                list.Add(new Player(1, "TestName", 3, 3, 2));
                return list;
            }

            IEnumerable IContainer.GetAll()
            {
                throw new NotImplementedException();
            }
        }

        public PlayerRepository TestRepository;

        [SetUp]
        public void SetUpAttributes()
        {
            TestRepository = new PlayerRepository(new TestContainer());
        }
        [Test]
        public void GetAllTest()
        {
            //arrange
            SetUpAttributes();
            List<Player> TestList = new List<Player>();

            //act
            TestList = TestRepository.GetAll();

            //assert
            Assert.NotNull(TestList);
        }

    }
}
