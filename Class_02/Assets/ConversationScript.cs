using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ConversationScript : MonoBehaviour
{
    public GameObject a;
    public string s;
    public string NpcName = "HaeDal";
    public GameObject UiText;
    public GameObject UiName;
    private TMP_Text N;
    private TMP_Text Conversation;

    // Start is called before the first frame update
    void Start(){
        
        N = UiName.GetComponent<TMP_Text>();
        Conversation = UiText.GetComponent<TMP_Text>();
    }
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.GetComponent<NPC>() != null){
            NPC npc = collision.GetComponent<NPC>();
            NpcName = npc.NAME;
            s = npc.ReturnConversation();

            a.SetActive(true);

            N.text = NpcName;
            Conversation.text = s;

        }
    }
    
}
