using EchoesOfTheRealmsShared.Services;
using Microsoft.AspNetCore.Mvc;

namespace EchoesOfTheRealmsAPI.Controllers
{
    [ApiController]
    [Route("api/Character")]

    public class PCController(PCService pCService) : ControllerBase
    {

        //Todo: Get pour afficher les personnages crées par un utilisateur

        [HttpGet]
        [EndpointDescription("Récupère les personnages liés à un utilisateur")]


        //Todo: Post pour créer un personnage
        [HttpPost]
        [EndpointDescription("Permet de créer un nouveau personnage lié à un utilisateur")]

        //Todo: Get pour stat perso ( a voir s'il faut pas changer la DB pour faire une classe avatar qui reprends les stats du perso + stat equip + stat job ... )


        //Todo: Get pour afficher les stat du perso
        [HttpGet]
        [EndpointDescription("Récupère les infos du personnage")]


        //Todo : Post pour modifier les stat du perso ( genre quand il up de lvl )
        [HttpPost]
        [EndpointDescription("Permet de modifier les stats d'un perso dans la DB")]


        //Todo: Get pour afficher l'inventaire du perso
        //Todo; Get pour afficher les items equipés par le perso

        //Todo : get pour afficher les items pour changement d'equipement ( genre quand on veut equiper une arme, on voit les armes dans l'inventaire )
        //Todo: Post pour equiper un item ou retirer un item

        //Todo: Update pour reposer le personnage ( genre quand il dort au campement )

    }

}
