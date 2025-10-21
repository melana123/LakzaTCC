using LaKzaTCC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LaKzaTCC.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        List<Categoria> categorias = new() {
            new Categoria { Id = 1, Nome = "Kit" },
            new Categoria { Id = 2, Nome = "Difusor de Aroma" },
            new Categoria { Id = 3, Nome = "Sabonetes" },
            new Categoria { Id = 4, Nome = "Vela" },
            new Categoria { Id = 5, Nome = "Aromatizador" },
            new Categoria { Id = 6, Nome = "Spray Car" },
        };
        builder.Entity<Categoria>().HasData(categorias);

        List<Produto> produtos = new List<Produto>
        {
            // Kit
            new Produto { Id = 1, CategoriaId = 1, Nome = "KIT ALMOFADA BABY ", ValorCusto = 4500.00m, ValorVenda = 118.00m, QtdeEstoque = 10, Destaque = true, ArquivoFoto = "/img/1.jpg", Descricao = "Kit de Almofadas Sachê Perfumado. Composto por almofadinhas artesanais, este conjunto é ideal para perfumar gavetas, armários, bolsas ou até mesmo para decorar ambientes com um toque acolhedor." },
            new Produto { Id = 2, CategoriaId = 1, Nome = "KIT PRESENTE", ValorCusto = 4000.00m, ValorVenda = 68.00m, QtdeEstoque = 15, Destaque = true, ArquivoFoto = "/img/2.jpeg", Descricao = "O gesso perfumado MAM Aromas é ideal para perfumar, decorar gavetas e armários. Pode ser colocado também em cabides, deixando um aroma incrível!" },
            new Produto { Id = 3, CategoriaId = 1, Nome = "KIT ALMOFADA TRUSS",  ValorCusto = 3500.00m, ValorVenda = 118.00m, QtdeEstoque = 20, ArquivoFoto = "/img/3.jpeg", Descricao = "Kit de Almofadas Sachê Perfumado. Composto por almofadinhas artesanais, este conjunto é ideal para perfumar gavetas, armários, bolsas ou até mesmo para decorar ambientes com um toque acolhedor." },
            

            // Difusor
            new Produto { Id = 4, CategoriaId = 2, Nome = "DIFUSOR DE AROMAS ALECRIM 250ML", ValorCusto = 8000.00m, ValorVenda = 238.00m, QtdeEstoque = 5, Destaque = true, ArquivoFoto = "/img/4.jpeg", Descricao = "Revitalize seu ambiente com o frescor herbal do difusor de aromas Alecrim 250ml. Perfeito para trazer energia, clareza e uma sensação de bem-estar ao seu espaço."  },
            new Produto { Id = 5, CategoriaId = 2, Nome = "DIFUSOR DE AROMAS BABY 300ML", ValorCusto = 7000.00m, ValorVenda = 238.00m, QtdeEstoque = 7, ArquivoFoto = "/img/5.jpeg", Descricao = "Crie uma atmosfera suave e acolhedora com o difusor de aromas Baby 300ml. Ideal para quartos de bebê e ambientes que pedem tranquilidade e conforto."  },
            new Produto { Id = 6, CategoriaId = 2, Nome = "DIFUSOR DE AROMAS ? 250ML", ValorCusto = 7500.00m, ValorVenda = 238.00m, QtdeEstoque = 6, ArquivoFoto = "/img/6.jpeg", Descricao = "Proporcione ao seu ambiente uma fragrância agradável e envolvente com o Difusor de Aromas ? 250ml. Ideal para renovar o ar e criar uma atmosfera acolhedora, seu aroma suave traz bem-estar e conforto para qualquer espaço."  },
            new Produto { Id = 7, CategoriaId = 2, Nome = "DIFUSOR DE AROMAS TRUSS 250ML", ValorCusto = 5000.00m, ValorVenda = 238.00m, QtdeEstoque = 10, ArquivoFoto = "/img/7.jpeg", Descricao = "Mantenha seu ambiente perfumado com a fragrância marcante e equilibrada do difusor Truss 250ml, que neutraliza odores e traz frescor duradouro."  },
            new Produto { Id = 8, CategoriaId = 2, Nome = "DIFUSOR DE AROMAS BOUQUET 250ML", ValorCusto = 7200.00m, ValorVenda = 238.00m, QtdeEstoque = 8, ArquivoFoto = "/img/8.jpeg", Descricao = "Encante seus sentidos com o aroma floral e vibrante do difusor Bouquet 250ml, ideal para criar um ambiente alegre e acolhedor."  },
            new Produto { Id = 9, CategoriaId = 2, Nome = "DIFUSOR DE AROMAS LIFE 250ML", ValorCusto = 7200.00m, ValorVenda = 168.00m, QtdeEstoque = 4, ArquivoFoto = "/img/9.jpeg", Descricao = "Leve vitalidade e frescor ao seu espaço com o difusor Life 250ml, perfeito para renovar o ambiente com uma fragrância leve e revigorante."  },
            new Produto { Id = 10, CategoriaId = 2, Nome = "DIFUSOR DE AROMAS CITRUS 250ML", ValorCusto = 7200.00m, ValorVenda = 238.00m, QtdeEstoque = 8, ArquivoFoto = "/img/10.jpeg", Descricao = "Desperte os sentidos com o frescor cítrico do difusor Citrus 250ml, ideal para ambientes que pedem energia e leveza."  },
            new Produto { Id = 11, CategoriaId = 2, Nome = "DIFUSOR DE AROMAS FIGO MADEIRA 250ML", ValorCusto = 7200.00m, ValorVenda = 168.00m, QtdeEstoque = 10, ArquivoFoto = "/img/11.jpeg", Descricao = "Combine a doçura do figo com a sofisticação das notas amadeiradas no difusor Figo Madeira 250ml, criando um aroma envolvente e aconchegante."  },
            new Produto { Id = 12, CategoriaId = 2, Nome = "DIFUSOR DE AROMAS MAGNOLIA 250ML", ValorCusto = 7200.00m, ValorVenda = 168.00m, QtdeEstoque = 9, ArquivoFoto = "/img/12.jpeg", Descricao = "Encante seus sentidos com a delicadeza e sofisticação do difusor de aromas Magnólia 250ml. Com uma fragrância floral fresca e levemente adocicada, traz leveza e elegância para qualquer ambiente, criando uma atmosfera acolhedora e revitalizante."  },
            new Produto { Id = 13, CategoriaId = 2, Nome = "DIFUSOR DE AROMAS MANDARINA 250ML", ValorCusto = 7200.00m, ValorVenda = 168.00m, QtdeEstoque = 8, ArquivoFoto = "/img/13.jpeg", Descricao = "Aromatize seu espaço com a fragrância doce e cítrica do difusor Mandarina 250ml, perfeita para trazer alegria e frescor." },
            new Produto { Id = 14, CategoriaId = 2, Nome = "DIFUSOR DE AROMAS VANILLA-PACHOULLI 250ML", ValorCusto = 7200.00m, ValorVenda = 168.00m, QtdeEstoque = 12, ArquivoFoto = "/img/14.jpeg", Descricao = "Desfrute da combinação sensual e sofisticada da baunilha com o toque terroso do patchouli no difusor Vanilla-Pachouli 250ml, para um ambiente elegante e acolhedor."  },
            new Produto { Id = 15, CategoriaId = 2, Nome = "DIFUSOR DE AROMAS BAMBOO 250ML", ValorCusto = 7200.00m, ValorVenda = 238.00m, QtdeEstoque = 8, ArquivoFoto = "/img/15.jpeg", Descricao = "Traga a pureza e frescor do bambu para seu ambiente com o difusor Bamboo 250ml, ideal para uma atmosfera tranquila e revigorante."  },

            // Sabonetes
            new Produto { Id = 16, CategoriaId = 3, Nome = "SABONETE LÍQUIDO BABY 350ML", ValorCusto = 2500.00m, ValorVenda = 128.00m, QtdeEstoque = 10, Destaque = true, ArquivoFoto = "/img/16.jpeg", Descricao = "Delicadamente formulado para cuidar da pele sensível do seu bebê, o Sabonete Líquido Baby 350ml oferece uma limpeza suave e eficaz. Enriquecido com ingredientes naturais, ele hidrata e protege, prevenindo o ressecamento e irritações. Sua fórmula hipoalergênica e dermatologicamente testada garante segurança e conforto durante o banho."  },
            new Produto { Id = 17, CategoriaId = 3, Nome = "SABONETE LÍQUIDO ? 350ML", ValorCusto = 1500.00m, ValorVenda = 128.00m, QtdeEstoque = 15, ArquivoFoto = "/img/17.jpeg", Descricao = "Sabonete líquido suave, ideal para limpeza diária da pele. Sua fórmula delicada limpa sem agredir, deixando a pele fresca, hidratada e perfumada. Pode ser usado no corpo e mãos, proporcionando sensação de limpeza e cuidado com praticidade."  },
            new Produto { Id = 18, CategoriaId = 3, Nome = "SABONETE LÍQUIDO TRUSS 350ML",  ValorCusto = 3500.00m, ValorVenda = 128.00m, QtdeEstoque = 5, ArquivoFoto = "/img/18.jpeg", Descricao = "O Sabonete Líquido Truss 350ml proporciona uma limpeza profunda e suave para a pele, aliado à tecnologia Truss de cuidado e proteção. Sua fórmula balanceada remove impurezas e oleosidade sem ressecar, deixando a pele macia, hidratada e revigorada. Ideal para o uso diário, oferece uma sensação refrescante e delicada fragrância que mantém a pele limpa e perfumada por mais tempo."  },
            new Produto { Id = 19, CategoriaId = 3, Nome = "SABONETE LÍQUIDO PRAIA 350ML",  ValorCusto = 800.00m, ValorVenda = 128.00m, QtdeEstoque = 20, ArquivoFoto = "/img/19.jpeg", Descricao = "Desperte a sensação refrescante do mar a cada banho com o Sabonete Líquido Praia 350ml. Sua fórmula leve e hidratante limpa suavemente a pele, removendo impurezas e proporcionando uma sensação de frescor e leveza inspirada na brisa do litoral. Ideal para uso diário, deixa a pele macia, perfumada e revigorada, como se você estivesse à beira-mar."  },
            new Produto { Id = 20, CategoriaId = 3, Nome = "SABONETE LÍQUIDO LIFE 350ML", ValorCusto = 1200.00m, ValorVenda = 128.00m, QtdeEstoque = 12, ArquivoFoto = "/img/20.jpeg" , Descricao = "O Sabonete Líquido Life 350ml oferece uma limpeza eficiente e suave para as mãos, removendo impurezas sem ressecar a pele. Sua fórmula hidratante mantém as mãos macias, frescas e agradavelmente perfumadas, ideal para o uso diário. Proporciona cuidado e proteção para que suas mãos fiquem sempre limpas e saudáveis." },
            new Produto { Id = 21, CategoriaId = 3, Nome = "SABONETE LÍQUIDO BAMBOO 350ML", ValorCusto = 1200.00m, ValorVenda = 128.00m, QtdeEstoque = 12, ArquivoFoto = "/img/21.jpeg", Descricao = "Descubra a refrescância natural do Sabonete Líquido Bamboo 350ml, formulado para limpar suavemente as mãos enquanto hidrata e protege a pele. Com extrato de bambu, conhecido por suas propriedades calmantes e revitalizantes, oferece uma experiência de limpeza leve e refrescante, deixando as mãos macias, frescas e delicadamente perfumadas. Ideal para o cuidado diário das suas mãos."  },
            new Produto { Id = 22, CategoriaId = 3, Nome = "SABONETE LÍQUIDO ALECRIM 350ML", ValorCusto = 1200.00m, ValorVenda = 128.00m, QtdeEstoque = 12, ArquivoFoto = "/img/22.jpeg", Descricao = "O Sabonete Líquido Alecrim 350ml limpa suavemente, enquanto o extrato de alecrim proporciona ação refrescante e antioxidante. Sua fórmula hidrata e protege a pele, deixando as mãos macias, perfumadas e revitalizadas. Ideal para o uso diário, oferece uma sensação energizante a cada lavagem."  },
            new Produto { Id = 23, CategoriaId = 3, Nome = "SABONETE MOUSSE VANILLA-PACHOULLI 300ML", ValorCusto = 1200.00m, ValorVenda = 78.00m, QtdeEstoque = 12, ArquivoFoto = "/img/23.jpeg", Descricao = "Desfrute de uma experiência luxuosa com o Sabonete Mousse Vanilla-Patchouli 300ml. Sua textura leve e cremosa envolve as mãos em uma espuma suave, limpando delicadamente sem ressecar a pele. A combinação envolvente da baunilha doce com o aroma terroso do patchouli deixa suas mãos perfumadas, macias e hidratadas. Perfeito para quem busca cuidado e fragrância sofisticada no dia a dia."  },
            new Produto { Id = 24, CategoriaId = 3, Nome = "SABONETE MOUSSE MANDARINA 300ML ", ValorCusto = 1200.00m, ValorVenda = 78.00m, QtdeEstoque = 12, ArquivoFoto = "/img/24.jpeg", Descricao = "Leve e refrescante, o Sabonete Mousse Mandarina 300ml limpa suavemente as mãos com sua textura mousse cremosa. Enriquecido com o aroma vibrante da mandarina, deixa uma sensação revigorante e uma fragrância cítrica deliciosa, enquanto hidrata e protege a pele. Ideal para o cuidado diário com toque de frescor."  },
            new Produto { Id = 25, CategoriaId = 3, Nome = "SABONETE MOUSSE MAGNÓLIA 300ML", ValorCusto = 1200.00m, ValorVenda = 78.00m, QtdeEstoque = 12, ArquivoFoto = "/img/25.jpeg", Descricao = "Delicadeza e frescor para suas mãos! O Sabonete Mousse Magnólia 300ml possui textura leve e cremosa que limpa suavemente, hidratando e deixando uma fragrância floral suave e elegante. Ideal para uso diário, proporciona uma experiência de cuidado delicado com perfume marcante e delicado."  },
            new Produto { Id = 27, CategoriaId = 3, Nome = "SABONETE MOUSSE FIGO-MADEIRA 300ML", ValorCusto = 1200.00m, ValorVenda = 78.00m, QtdeEstoque = 12, ArquivoFoto = "/img/27.jpeg", Descricao = "Uma combinação sofisticada e envolvente para suas mãos. O Sabonete Mousse Figo-Madeira 300ml oferece uma limpeza suave com sua textura cremosa e espuma leve, enquanto a fragrância marcante do figo se mistura às notas quentes da madeira, proporcionando uma experiência sensorial única. Hidrata e protege a pele, deixando as mãos macias e perfumadas por mais tempo."  },
            new Produto { Id = 28, CategoriaId = 3, Nome = "SABONETE MOUSSE CITRUS 300ML", ValorCusto = 1200.00m, ValorVenda = 78.00m, QtdeEstoque = 12, ArquivoFoto = "/img/28.jpeg", Descricao = "Refresque suas mãos com o toque vibrante do Sabonete Mousse Citrus 300ml. Sua textura leve e cremosa forma uma espuma suave que limpa delicadamente, enquanto a fragrância cítrica revitalizante deixa uma sensação de frescor e energia. Perfeito para o uso diário, hidrata e protege a pele, mantendo suas mãos macias e perfumadas."  },
            new Produto { Id = 29, CategoriaId = 3, Nome = "SABONETE MOUSSE BOUQUET DE VERÃO 300ML", ValorCusto = 1200.00m, ValorVenda = 78.00m, QtdeEstoque = 12, ArquivoFoto = "/img/29.jpeg", Descricao = "Celebre a leveza do verão com o Sabonete Mousse Bouquet de Verão 300ml. Sua textura cremosa e delicada espuma limpam suavemente as mãos, enquanto a fragrância floral e fresca do bouquet de verão traz uma sensação revigorante e alegre. Hidrata e protege a pele, deixando suas mãos macias, perfumadas e prontas para o dia a dia."  },

            // Vela
            new Produto { Id = 30, CategoriaId = 4, Nome = "VELA DECORATIVA TRUSS", ValorCusto = 900.00m, ValorVenda = 168.00m, QtdeEstoque = 12, Destaque = true, ArquivoFoto = "/img/30.jpeg", Descricao = "A Vela Decorativa Truss combina elegância e aconchego para transformar qualquer ambiente. Com design sofisticado e acabamento impecável, cria uma atmosfera acolhedora e sofisticada, perfeita para momentos de relaxamento ou para complementar a decoração da sua casa. Ideal para presentear ou para deixar seu espaço ainda mais especial."  },
            new Produto { Id = 31, CategoriaId = 4, Nome = "VELA AROMÁTICA VANILLA-PACHOULLI",  ValorCusto = 1400.00m, ValorVenda = 92.00m, QtdeEstoque = 10, ArquivoFoto = "/img/31.jpeg", Descricao = "Envolva seus sentidos com a combinação sofisticada da Vanilla-Patchouli. Esta vela aromática libera uma fragrância quente e envolvente, unindo a doçura aconchegante da baunilha com as notas terrosas e amadeiradas do patchouli. Ideal para criar um ambiente relaxante e acolhedor, perfeito para momentos de tranquilidade e bem-estar."  },
            new Produto { Id = 32, CategoriaId = 4, Nome = "VELA AROMÁTICA BOUQUET",  ValorCusto = 600.00m, ValorVenda = 92.00m, QtdeEstoque = 20, ArquivoFoto = "/img/32.jpeg", Descricao = "Traga a essência de um jardim florido para o seu ambiente com a Vela Aromática Bouquet. Sua fragrância floral delicada e sofisticada cria uma atmosfera acolhedora e refrescante, ideal para relaxar e renovar as energias. Perfeita para decorar e perfumar qualquer espaço com charme e elegância."  },
            new Produto { Id = 33, CategoriaId = 4, Nome = "VELA AROMÁTICA CITRUS", ValorCusto = 800.00m, ValorVenda = 92.00m, QtdeEstoque = 15, ArquivoFoto = "/img/33.jpeg", Descricao = "Desperte seus sentidos com a refrescante e vibrante fragrância da vela aromática citrus. Feita para transformar qualquer ambiente, essa vela combina notas cítricas energizantes como limão, laranja e grapefruit, trazendo uma sensação de leveza, frescor e vitalidade. Ideal para momentos de relaxamento, renovação e equilíbrio, sua queima suave e prolongada cria uma atmosfera acolhedora e revigorante, perfeita para renovar o espírito e iluminar o dia a dia."  },
            new Produto { Id = 34, CategoriaId = 4, Nome = "VELA AROMÁTICA FIGO-MADEIRA",  ValorCusto = 400.00m, ValorVenda = 92.00m, QtdeEstoque = 25, ArquivoFoto = "/img/34.jpeg", Descricao = "Encante seus sentidos com a sofisticada combinação da vela aromática figo-madeira. Com a doçura sutil e fresca do figo unida às notas quentes e terrosas da madeira, essa vela cria um aroma envolvente e equilibrado, perfeito para ambientes aconchegantes. Ideal para momentos de relaxamento e introspecção, sua fragrância única traz uma sensação de conforto, elegância e bem-estar, tornando qualquer espaço mais acolhedor e sofisticado."  },
            new Produto { Id = 35, CategoriaId = 4, Nome = "VELA AROMÁTICA LAVANDA",  ValorCusto = 400.00m, ValorVenda = 92.00m, QtdeEstoque = 25, ArquivoFoto = "/img/35.jpeg", Descricao = "Relaxe e harmonize o ambiente com a delicada fragrância da vela aromática lavanda. Conhecida por suas propriedades calmantes e relaxantes, a lavanda traz uma sensação de paz e tranquilidade, ideal para desacelerar após um dia agitado. Com sua queima suave e duradoura, essa vela cria um ambiente sereno e acolhedor, perfeito para meditação, descanso ou momentos de autocuidado."  },
            new Produto { Id = 36, CategoriaId = 4, Nome = "VELA AROMÁTICA MAGNÓLIA",  ValorCusto = 400.00m, ValorVenda = 92.00m, QtdeEstoque = 25, ArquivoFoto = "/img/36.jpeg" , Descricao = "Encante seus sentidos com a elegante fragrância da vela aromática magnólia. Com um aroma floral delicado, fresco e levemente adocicado, a magnólia traz sofisticação e leveza para qualquer ambiente. Ideal para criar uma atmosfera acolhedora e revigorante, essa vela proporciona momentos de tranquilidade e bem-estar, iluminando seu espaço com charme e suavidade." },
            new Produto { Id = 37, CategoriaId = 4, Nome = "VELA AROMÁTICA MANDARINA",  ValorCusto = 400.00m, ValorVenda = 92.00m, QtdeEstoque = 25, ArquivoFoto = "/img/37.jpeg", Descricao = "Revitalize seu ambiente com a energia vibrante da vela aromática mandarina. Seu aroma cítrico, doce e refrescante traz uma sensação de alegria e leveza, perfeita para renovar o espírito e despertar os sentidos. Ideal para criar uma atmosfera acolhedora e cheia de vitalidade, essa vela é o toque perfeito para momentos de descontração e bem-estar."  },
           
            // Aromatizador
            new Produto { Id = 38, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES ? 500ML",  ValorCusto = 1200.00m, ValorVenda = 208.00m, QtdeEstoque = 8, Destaque = true, ArquivoFoto = "/img/38.jpeg", Descricao = "Transforme qualquer espaço com o Aromatizador de Ambientes 500ml, ideal para perfumar e renovar o ar de sua casa, escritório ou qualquer ambiente. Com uma fragrância envolvente e duradoura, proporciona uma atmosfera acolhedora, fresca e agradável. Sua embalagem prática permite fácil aplicação, garantindo uma sensação de bem-estar e conforto a cada borrifada."  },
            new Produto { Id = 39, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES TRUSS 500ML", ValorCusto = 1400.00m, ValorVenda = 208.00m, QtdeEstoque = 10, ArquivoFoto = "/img/39.jpeg", Descricao = "Proporcione frescor e sofisticação ao seu ambiente com o Aromatizador de Ambientes Truss 500ml. Sua fragrância marcante e duradoura neutraliza odores indesejados, deixando o espaço perfumado de forma equilibrada e agradável. Ideal para usar em casa, no escritório ou em qualquer lugar que você deseje renovar a atmosfera com praticidade e estilo."  },
            new Produto { Id = 40, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES PRAIA 500ML",  ValorCusto = 900.00m, ValorVenda = 208.00m, QtdeEstoque = 15, ArquivoFoto = "/img/40.jpeg", Descricao = "Leve a brisa refrescante e a vibe relaxante do litoral para dentro do seu ambiente com o Aromatizador de Ambientes Praia 500ml. Com uma fragrância leve e revigorante que remete ao frescor do mar, areia e sol, ele transforma qualquer espaço em um verdadeiro refúgio de tranquilidade e bem-estar. Ideal para renovar o ar da sua casa com a sensação de férias o ano todo."  },
            new Produto { Id = 41, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES LIFE 500ML", ValorCusto = 2000.00m, ValorVenda = 208.00m, QtdeEstoque = 5, ArquivoFoto = "/img/41.jpeg", Descricao = "Renove a energia do seu espaço com o Aromatizador de Ambientes Life 500ml. Com uma fragrância fresca e vibrante, ele traz uma sensação de vitalidade e bem-estar, deixando qualquer ambiente mais acolhedor e revigorante. Ideal para quem busca um toque de leveza e equilíbrio no dia a dia."  },
            new Produto { Id = 42, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES BAMBOO 500ML",  ValorCusto = 2500.00m, ValorVenda = 208.00m, QtdeEstoque = 6, ArquivoFoto = "/img/42.jpeg", Descricao = "Traga a essência da natureza para o seu ambiente com o Aromatizador de Ambientes Bamboo 500ml. Sua fragrância fresca e suave, inspirada no aroma natural do bambu, cria uma atmosfera relaxante e revigorante, ideal para renovar o ar da sua casa ou escritório. Perfeito para quem busca um toque de frescor e tranquilidade em qualquer espaço."  },
            new Produto { Id = 43, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES BABY 500ML", ValorCusto = 2000.00m, ValorVenda = 208.00m, QtdeEstoque = 5, ArquivoFoto = "/img/43.jpeg", Descricao = "Crie um ambiente suave e acolhedor com o Aromatizador de Ambientes Baby 500ml. Com uma fragrância delicada e doce, especialmente desenvolvida para trazer conforto e tranquilidade, é perfeito para quartos de bebê, espaços de descanso ou qualquer lugar que precise de uma atmosfera calma e serena. Proporcione bem-estar e aconchego para toda a família."  },
            new Produto { Id = 44, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES ALECRIM 500ML", ValorCusto = 2000.00m, ValorVenda = 208.00m, QtdeEstoque = 5, ArquivoFoto = "/img/44.jpeg", Descricao = "Renove o ar do seu espaço com a fragrância refrescante e herbal do Aromatizador de Ambientes Alecrim 500ml. Conhecido por suas propriedades revigorantes e estimulantes, o alecrim traz uma sensação de clareza e energia, ideal para ambientes que pedem foco e vitalidade. Perfeito para casa, escritório ou qualquer lugar onde você queira um toque de frescor natural."  },
            new Produto { Id = 45, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES BABY 200ML", ValorCusto = 2000.00m, ValorVenda = 208.00m, QtdeEstoque = 5, ArquivoFoto = "/img/45.jpeg", Descricao = "Proporcione um ambiente calmo e acolhedor com o Aromatizador de Ambientes Baby 200ml. Sua fragrância suave e delicada é especialmente desenvolvida para criar uma atmosfera tranquila, perfeita para quartos de bebê, áreas de descanso e espaços que pedem conforto e serenidade. Ideal para garantir bem-estar e aconchego para toda a família."  },
            new Produto { Id = 46, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES PRAIA 120ML", ValorCusto = 2000.00m, ValorVenda = 128.00m, QtdeEstoque = 5, ArquivoFoto = "/img/46.jpeg", Descricao = "Leve a refrescância do mar para qualquer lugar com o Aromatizador de Ambientes Praia 120ml. Com uma fragrância leve e revigorante que lembra a brisa do litoral, areia e sol, esse aromatizador é perfeito para renovar o ar de ambientes pequenos, trazendo a sensação de férias e tranquilidade onde você estiver."  },
            new Produto { Id = 47, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES ? 120ML", ValorCusto = 2000.00m, ValorVenda = 128.00m, QtdeEstoque = 5, ArquivoFoto = "/img/47.jpeg" , Descricao = "Perfume seus espaços com o Aromatizador de Ambientes ? 120ml, perfeito para renovar o ar de ambientes pequenos e médios. Com uma fragrância envolvente e delicada, proporciona uma atmosfera agradável e acolhedora, ideal para deixar sua casa ou escritório mais convidativo e harmonioso." },
            new Produto { Id = 48, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES TRUSS 120ML", ValorCusto = 2000.00m, ValorVenda = 128.00m, QtdeEstoque = 5, ArquivoFoto = "/img/48.jpeg", Descricao = "Refresque e transforme qualquer ambiente com o Aromatizador de Ambientes Truss 120ml. Com uma fragrância marcante e equilibrada, ele neutraliza odores indesejados e deixa o espaço perfumado de forma suave e duradoura. Ideal para uso em casa, escritório ou qualquer lugar que precise de um toque de frescor e bem-estar."  },
            new Produto { Id = 49, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES LIFE 120ML", ValorCusto = 2000.00m, ValorVenda = 128.00m, QtdeEstoque = 5, ArquivoFoto = "/img/49.jpeg", Descricao = "Revitalize seu espaço com o Aromatizador de Ambientes Life 120ml. Sua fragrância fresca e vibrante traz uma sensação de energia e bem-estar, deixando qualquer ambiente mais leve e acolhedor. Ideal para renovar o ar de pequenos espaços com praticidade e estilo."  },
            new Produto { Id = 50, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES BAMBOO 120ML", ValorCusto = 2000.00m, ValorVenda = 128.00m, QtdeEstoque = 5, ArquivoFoto = "/img/50.jpeg", Descricao = "Traga o frescor natural do bambu para dentro do seu ambiente com o Aromatizador de Ambientes Bamboo 120ml. Com uma fragrância suave e refrescante, ele cria uma atmosfera relaxante e revigorante, perfeita para renovar o ar de sua casa ou escritório."  },
            new Produto { Id = 51, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES ALECRIM 120ML", ValorCusto = 2000.00m, ValorVenda = 128.00m, QtdeEstoque = 5, ArquivoFoto = "/img/51.jpeg", Descricao = "Desperte seus sentidos com o Aromatizador de Ambientes Alecrim 120ml. Com aroma herbal e refrescante, é ideal para ambientes que precisam de energia, foco e vitalidade. Perfeito para uso em casa ou no trabalho, trazendo frescor natural a qualquer espaço."  },
            new Produto { Id = 52, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES BOUQUET DE VERÃO 200ML", ValorCusto = 2000.00m, ValorVenda = 88.00m, QtdeEstoque = 5, ArquivoFoto = "/img/52.jpeg", Descricao = "Encante seu ambiente com o Aromatizador de Ambientes Bouquet de Verão 200ml. Com uma fragrância floral e frutada que remete à leveza e alegria da estação mais quente, ele traz frescor e bem-estar para sua casa, criando uma atmosfera acolhedora e vibrante."  },


            //Spray car
            new Produto { Id = 53, CategoriaId = 6, Nome = "SPRAY CAR TRUSS 60ML",  ValorCusto = 700.00m, ValorVenda = 58.00m, QtdeEstoque = 20, Destaque = true, ArquivoFoto = "/img/53.jpeg", Descricao = "Mantenha o interior do seu carro sempre fresco e agradável com o Spray Car Truss 60ml. Compacto e prático, esse spray oferece uma fragrância envolvente que elimina odores indesejados, deixando um aroma limpo e duradouro. Ideal para uso diário, proporciona uma experiência refrescante toda vez que você entra no veículo, garantindo conforto e bem-estar em suas viagens."  },
            new Produto { Id = 54, CategoriaId = 6, Nome = "SPRAY CAR BAMBOO 60ML",  ValorCusto = 800.00m, ValorVenda = 58.00m, QtdeEstoque = 12, ArquivoFoto = "/img/54.jpeg", Descricao = "Leve a sensação de frescor natural para dentro do seu carro com o Spray Car Bamboo 60ml. Com uma fragrância leve e revigorante inspirada no aroma fresco e verde do bambu, esse spray neutraliza odores e deixa seu veículo com um perfume suave e duradouro. Perfeito para quem busca um ambiente limpo e tranquilo durante suas viagens."  },
    

        };
        builder.Entity<Produto>().HasData(produtos);

        #region Populate Roles - Perfis de Usuário
        List<IdentityRole> roles = new()
        {
            new IdentityRole() {
               Id = "0b44ca04-f6b0-4a8f-a953-1f2330d30894",
               Name = "Administrador",
               NormalizedName = "ADMINISTRADOR"
            },
            new IdentityRole() {
               Id = "bec71b05-8f3d-4849-88bb-0e8d518d2de8",
               Name = "Funcionário",
               NormalizedName = "FUNCIONÁRIO"
            },
            new IdentityRole() {
               Id = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
               Name = "Cliente",
               NormalizedName = "CLIENTE"
            },
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Populate Usuário
        List<Usuario> usuarios = new() {
            new Usuario(){
                Id = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                Email = "gallojunior@gmail.com",
                NormalizedEmail = "GALLOJUNIOR@GMAIL.COM",
                UserName = "AnaZinsly",
                NormalizedUserName = "ANALUIZA",
                LockoutEnabled = true,
                EmailConfirmed = true,
                Nome = "Ana Luiza Zinsly",
            }
        };
        foreach (var user in usuarios)
        {
            PasswordHasher<IdentityUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "123456");
        }
        builder.Entity<Usuario>().HasData(usuarios);
        #endregion

        #region Populate UserRole - Usuário com Perfil
        List<IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole<string>() {
                UserId = usuarios[0].Id,
                RoleId = roles[0].Id
            },
            new IdentityUserRole<string>() {
                UserId = usuarios[0].Id,
                RoleId = roles[1].Id
            },
            new IdentityUserRole<string>() {
                UserId = usuarios[0].Id,
                RoleId = roles[2].Id
            }
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion
    }
}