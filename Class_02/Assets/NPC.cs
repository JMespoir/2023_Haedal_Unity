using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public string NAME = "HAEDAL";
    private string[] Conversations = {
        "해달 부트캠프 너무 재밌었고, 다음에는 제가 부트캠프 맡아서 유니티 해보고 싶어요!!",
        "다들 유니티 배워보는 건 어떨까요?",
        "해달 부트캠프와 함께라면 유니티 어렵지 않아요!!",
        "저는 글솝 22학번이에요!!",
        "유니티 부트캠프는 최고의 선택이에요^^"
    }; 
    private int ConSize = 5;
    private int ConversationIndex =0;
    
    public string ReturnConversation(){
        ConversationIndex = Random.Range(0,ConSize);
        return Conversations[ConversationIndex];
    }

    // Update is called once per frame
}
