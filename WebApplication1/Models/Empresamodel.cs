using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApplication1.Models
{
    public class Empresamodel 
    {
        public List<Empresa> ListadoEmpresa()
        {
            var lista = new List<Empresa>();

            lista.Add(new Empresa
            {
                id = 1,
                nombre = "Discoteca Dalí",
                descripcion = "Discoteca Dali se puede encontrar la música mas variada y un ambiente super agradable! Conoce muchos chicas y chicos juerguer@s y pásala bravazo con tus patas! Pásala bien en Dali, una de los discos más preferidos en Baranco.",
                logo = "https://raw.githubusercontent.com/SergioChM/Diskotekate/master/images/dali.png"

            });
       
            lista.Add(new Empresa
            {
                id = 2,
                nombre = ">Gotica Disco",
                descripcion = "GOTICA es una de las discotecas mas concurridas, por la gente miraflorina; cuenta con los mejores ambientes, muy amplios y agradables donde se encuentran a los mejores DJ’s del momento que te invitan a celebrar con tus amigos y/o pareja.",
                logo = "https://raw.githubusercontent.com/SergioChM/Diskotekate/master/images/gotica.png"

            });
            lista.Add(new Empresa
            {
                id = 3,
                nombre = "Bunker",
                descripcion = "Bunker se puede encontrar la música más variada y un ambiente super agradable! Conoce muchos chicas y chicos juerguer@s y pásala bravazo con tus patas! Pásala bien en El Bunker, una de las discotecas más preferidos en Barranco.",
                logo = "https://raw.githubusercontent.com/SergioChM/Diskotekate/master/images/bunker.png"

            });
            lista.Add(new Empresa
            {
                id = 4,
                nombre = "Toro Retro Bar",
                descripcion = "l Toro Bar es tu lugar, una discoteca con buena música, las mejores bandas y gente divertida. Toro Retro Bar está ubicado en Barranco y promete hacer de tus noches de fin de semana las mejores. La juerga está asegurada en este peculiar y asombroso lugar",
                logo = "https://raw.githubusercontent.com/SergioChM/Diskotekate/master/images/toro.png"

            });
            lista.Add(new Empresa
            {
                id = 5,
                nombre = "Mokka",
                descripcion = "En Mokka Disco se puede encontrar la música mas variada y un ambiente super agradable! Conoce muchos chicas y chicos juerguer@s y pásala bravazo con tus patas! Pásala bien en Mokka Disco, una de las discotecas más preferidas en Miraflores.",
                logo = "https://raw.githubusercontent.com/SergioChM/Diskotekate/master/images/mokka.png"

            });
            lista.Add(new Empresa
            {
                id = 5,
                nombre = "Embarcadero 41",
                descripcion = "Discoteca Embarcadero 41 es uno de los centros de diversión más concurridos y preferidos del distrito de Barranco. Pásala bien en Discoteca Embarcadero 41, una de las discotecas más preferida en Barranco. Chicas y Chicos bailando los ritmos de moda.",
                logo = "https://raw.githubusercontent.com/SergioChM/Diskotekate/master/images/embarcadero.png"

            });

            return lista;
        }
    }
}