using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShareScript : MonoBehaviour
{
    public Player playerScript;


    #region FaceBook Variables
    string appID = "2454944607897969";

    string link = "https://ashjugdav.wixsite.com/abstinencetestsite";

    string picture = "https://i.imgur.com/yhcCF4n.jpg";

    string caption = "Check out my score:";

    string description = "Enjoy fun, free games! Challenge yourself or share with friends. Fun and easy to use games";
    #endregion

    public void shareScoreOnFacebook()
    {
        Application.OpenURL("https://www.facebook.com/dialog/feed?" + "app_id=" + appID + "&display =" + "popup" + "&picture=" + picture + "&href=" + link + "&caption=" + caption + "&hashtag=" + "#SoberSociety");

    }

    string TWITTER_ADDRESS = "https://twitter.com/intent/tweet";

    string TWEET_LANGUAGE = "en";

    string textToDisplay = "Hey Guys, check out my high score: ";

    public void shareScoreOnTwitter()
    {
        Application.OpenURL(TWITTER_ADDRESS + "?text=" + WWW.EscapeURL(textToDisplay) + playerScript.score + WWW.EscapeURL(" #SoberSociety #Abstinence ") + WWW.EscapeURL(link) + "&amp;lang=" + WWW.EscapeURL(TWEET_LANGUAGE));
    }
}
