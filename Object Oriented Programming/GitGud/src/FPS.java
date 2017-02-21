/**
 * Created by arodriguez on 1/25/2017.
 */
public class FPS extends Game{
    public FPS(){
        difficulty = 2;
        gameComplexity = 4;
    }

    public void PlayCampaign(Player player){
        player.wellRestedPts -= 1;
    }
    public void PlayMultiplayer(Player player){
        player.skillLevel += 1;
        player.wellRestedPts -= 2;
    }
}
