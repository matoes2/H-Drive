/**
 * Created by arodriguez on 1/25/2017.
 */
public class RPG extends Game{
    public RPG() {
        difficulty = 1;
        gameComplexity = 3;
    }

    public void PlayPvE(Player player){
        player.wellRestedPts -= 5;
    }

    public void PlayPvP(Player player){
        player.skillLevel += 1;
        player.wellRestedPts -= 4;
    }
}
