
using FrequencyQuerySolver.Queries;

namespace FrequencyQuerySolver
{
    [TestFixture]
    public class FrequencyQueryHandlerTests
    {
        [Test]
        public void PerformQueries_ShouldReturnExpectedResult()
        {
            // Arrange
            var handler = new FrequencyQueryHandler();
            int[][] queries = {
                new int[] {1, 1},
                new int[] {2, 2},
                new int[] {3, 2},
                new int[] {1, 1},
                new int[] {1, 1},
                new int[] {2, 1},
                new int[] {3, 2}
            };

            // Act
            var result = handler.PerformQueries(queries);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
            Assert.AreEqual(1, result[2]);
        }

        [Test]
        public void PerformQueries_ShouldHandleEmptyQueryList()
        {
            
            var handler = new FrequencyQueryHandler();
            int[][] emptyQueries = { };

        
            var result = handler.PerformQueries(emptyQueries);

         
            Assert.IsNotNull(result);
            Assert.IsEmpty(result);
        }

        [Test]
        public void PerformQueries_ShouldHandleSingleQuery()
        {
           
            var handler = new FrequencyQueryHandler();
            int[][] singleQuery = {
                new int[] {1, 1}
            };

           
            var result = handler.PerformQueries(singleQuery);

   
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(0, result[0]);
        }

        [Test]
        public void PerformQueries_ShouldHandleMultipleQueries()
        {
            
            var handler = new FrequencyQueryHandler();
            int[][] multipleQueries = {
                new int[] {1, 1},
                new int[] {2, 1},
                new int[] {3, 1},
                new int[] {1, 2},
                new int[] {1, 2},
                new int[] {3, 1}
            };

           
            var result = handler.PerformQueries(multipleQueries);

           
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(0, result[1]);
        }

        [Test]
        public void PerformQueries_ShouldHandleDeleteOperationWithNonExistingElement()
        {
            
            var handler = new FrequencyQueryHandler();
            int[][] queries = {
                new int[] {2, 5}
            };

           
            var result = handler.PerformQueries(queries);

          
            Assert.IsNotNull(result);
            Assert.IsEmpty(result);
        }

        [Test]
        public void PerformQueries_ShouldHandleCheckOperationWithNonExistingElement()
        {
           
            var handler = new FrequencyQueryHandler();
            int[][] queries = {
                new int[] {3, 3}
            };

          
            var result = handler.PerformQueries(queries);
                      
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(0, result.First());
        }

        
    }
}
