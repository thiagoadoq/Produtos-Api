using Corporate.Havan.Schedule.Application.Contracts.Applications;
using Corporate.Havan.Schedule.Application.Mapping.Dto;
using Moq;
using Xunit;

namespace Corporate.Havan.Schedule.Test
{
    public class ProductTests
    {      
        [Fact]
        public void Get_Produto_By_Id_Returns_Produto()
        {
            Moq.Mock<IProdutoApplication> mock = new Moq.Mock<IProdutoApplication>();
            mock.Setup(x => x.GetById(It.IsAny<int>())).Returns(new ProdutoDto { Nome = "Sabão", Preco = 10 });

            var produtoApplication = (IProdutoApplication) mock.Object;

            Assert.NotNull(produtoApplication.GetById(1));
        }

        [Fact]
        public void Get_Produto_By_Id_Validate_Object()
        {
            Moq.Mock<IProdutoApplication> mock = new Moq.Mock<IProdutoApplication>();
            mock.Setup(x => x.GetById(It.IsAny<int>())).Returns(new ProdutoDto());

            var produtoApplication = (IProdutoApplication)mock.Object;

            var produto = produtoApplication.GetById(1);
            
            Assert.Equal(0,produto.Preco);
            Assert.Null(produto.Nome);   
        }
    }
}