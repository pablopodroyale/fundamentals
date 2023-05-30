using Challenges.Beginner.MiddleNode;

namespace Tests.Challenges.Beginner
{
    public class MiddleNodeTest
    {
        private MiddleNode _underTest;

        [SetUp]
        public void SetUp()
        {
            _underTest = new MiddleNode();
        }

        [Test]
        [TestCase(new int[] {1, 2, 3, 4, 5 },new int[] { 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 4, 5, 6 })]
        public void MiddleNodeSolutionTest(int[] nums, int[] expectedValues)
        {
            ListNode listNode = GetNodes(nums);
            ListNode expected = GetNodes(expectedValues);
            ListNode result = _underTest.MiddleNodeSolution(listNode);
            Assert.That(ListNodeToArray(expected), Is.EquivalentTo(ListNodeToArray(result)));
        }

        private List<int> ListNodeToArray(ListNode node)
        {
            ListNode nodeAux = node;
            List<int> result = new List<int>();
            do
            {
                result.Add(nodeAux.val);
                nodeAux = nodeAux.next;
            } while (nodeAux != null);

            return result;
        }

        private ListNode GetNodes(int[] expectedValues)
        {
            ListNode listNode = null;
            ListNode aux = null;

            for (int i = expectedValues.Length; i >= 1; i--)
            {
                if (i == expectedValues.Length)
                {
                    listNode = new ListNode(expectedValues[i - 1]);
                }
                else
                {
                    aux = new ListNode(expectedValues[i - 1], listNode);
                    listNode = aux;
                }
            }

            return listNode;
        }


    }
}
