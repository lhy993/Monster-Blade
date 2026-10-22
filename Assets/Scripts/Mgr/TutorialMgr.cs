using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI    ;

public class TutorialMgr : MonoBehaviour
{
    public GameObject portal;

    public RectTransform arrow;
    public Text Tip;

    public Image RMoveBtn;
    public Image LMoveBtn;
    public Image JumpBtn;
    public Image AtkBtn;
    public Image BlockBtn;
    public Image interactionBtn;
    private void Awake()
    {
        if (Shared.TutorialMgr == null)
        {
            Shared.TutorialMgr = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Portal()
    {
        portal.SetActive(true);
    }

    public void Next(int Tutorial)
    {
        Shared.BattleMgr.TutorialStage = Tutorial;

        switch (Shared.BattleMgr.TutorialStage)
        {
            case 1:
                RMoveBtn.color = new Color(1, 1, 1, 1);
                LMoveBtn.color = new Color(1, 1, 1, 1);

                Tip.text = "버튼을 눌러 \n 좌우로 이동하기";
                break;
            case 2:
                JumpBtn.color = new Color(1, 1, 1, 1);

                RMoveBtn.color = new Color(1, 1, 1, 0.5f);
                LMoveBtn.color = new Color(1, 1, 1, 0.5f);

                Tip.text = "버튼을 눌러 \n 점프하기";
                break;
            case 3:
                AtkBtn.color = new Color(1, 1, 1, 1);

                JumpBtn.color = new Color(1, 1, 1, 0.5f);

                Tip.text = "버튼을 눌러 \n 공격하기";
                break;
            case 4:
                BlockBtn.color = new Color(1, 1, 1, 1);

                AtkBtn.color = new Color(1, 1, 1, 0.5f);

                Tip.text = "버튼을 눌러 \n 방어하기";
                break;
            case 5:
                interactionBtn.color = new Color(1, 1, 1, 1);

                BlockBtn.color = new Color(1, 1, 1, 0.5f);

                Tip.text = "포탈 앞으로 이동하고 \n 상호작용 버튼 누르기";
                break;

        }
    }
}
