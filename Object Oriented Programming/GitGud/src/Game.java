/**
 * Created by arodriguez on 1/25/2017.
 */
public class Game extends Player {
    public int difficulty;
    public int gameComplexity;
    public Game(){

    }
    public void GitGud(Player player){
        player.skillLevel += difficulty;
        player.wellRestedPts -= gameComplexity;
    }
    public void GoToSleep(Player player){
        player.wellRestedPts += 10;
    }
}
