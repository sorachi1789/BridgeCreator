using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DropImage : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Image Bottom;
    public Image Bottom2;
    public Image String;

    private Sprite nowSpriteBottom;
    private Sprite nowSpriteString;
    private Sprite nowSpriteBottom2;

    private Color OldImageString;
    private Color OldImageBottom2;

    bool BottomCheck =false;

    public Sprite[] ImageSet;

    public int BottomPicker = 0;
    public int StringPicker = 0;

    void Start()
    {
        nowSpriteBottom2 = null;
        nowSpriteString = null;
        nowSpriteBottom = null;
    }

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        if (pointerEventData.pointerDrag == null) return;
        Image droppedImage = pointerEventData.pointerDrag.GetComponent<Image>();

        if (droppedImage.CompareTag("Glass") || droppedImage.CompareTag("Pipe")
            || droppedImage.CompareTag("Wood_M") || droppedImage.CompareTag("Wood_B"))
        {
            if (droppedImage.CompareTag("Glass"))
            {
                Bottom2.sprite = ImageSet[0];
                if (StringPicker == 1)
                {
                    String.sprite = ImageSet[11];
                    Bottom.sprite = ImageSet[8];
                }
                if (StringPicker == 2)
                {
                    String.sprite = ImageSet[6];
                    Bottom.sprite = ImageSet[8];
                }
            }
            if (droppedImage.CompareTag("Pipe"))
            {
                Bottom2.sprite = ImageSet[1];
                if (StringPicker == 1)
                {
                    String.sprite = ImageSet[5];
                    Bottom.sprite = ImageSet[9];
                }
                if (StringPicker == 2)
                {
                    String.sprite = ImageSet[7];
                    Bottom.sprite = ImageSet[10];
                }
            }
            if (droppedImage.CompareTag("Wood_M"))
            {
                Bottom2.sprite = ImageSet[2];
                if (StringPicker == 1)
                {
                    String.sprite = ImageSet[5];
                    Bottom.sprite = ImageSet[9];
                }
                if (StringPicker == 2)
                {
                    String.sprite = ImageSet[12];
                    Bottom.sprite = ImageSet[9];
                }
            }
            if (droppedImage.CompareTag("Wood_B"))
            {
                Bottom2.sprite = ImageSet[3];
                if (StringPicker == 1)
                {
                    String.sprite = ImageSet[4];
                    Bottom.sprite = ImageSet[8];
                }
                if (StringPicker == 2)
                {
                    String.sprite = ImageSet[6];
                    Bottom.sprite = ImageSet[8];
                }
            }
            Bottom2.color = droppedImage.color * 0.8f;
        }

        if (BottomCheck && droppedImage.CompareTag("String") || droppedImage.CompareTag("Nail"))
        {
            if (droppedImage.CompareTag("String"))
            {
                if (BottomPicker == 1)
                {
                    String.sprite = ImageSet[11];
                    Bottom.sprite = ImageSet[8];
                }
                if (BottomPicker == 4)
                {
                    String.sprite = ImageSet[4];
                    Bottom.sprite = ImageSet[8];
                }
                if (BottomPicker == 2)
                {
                    String.sprite = ImageSet[5];
                    Bottom.sprite = ImageSet[9];
                }
                if (BottomPicker == 3)
                {
                    String.sprite = ImageSet[5];
                    Bottom.sprite = ImageSet[9];
                }
            }
            if (droppedImage.CompareTag("Nail"))
            {
                if (BottomPicker == 1)
                {
                    String.sprite = ImageSet[6];
                    Bottom.sprite = ImageSet[8];
                }
                if (BottomPicker == 4)
                {
                    String.sprite = ImageSet[6];
                    Bottom.sprite = ImageSet[8];
                }
                if (BottomPicker == 2)
                {
                    String.sprite = ImageSet[7];
                    Bottom.sprite = ImageSet[10];
                }
                if (BottomPicker == 3)
                {
                    String.sprite = ImageSet[12];
                    Bottom.sprite = ImageSet[9];
                }
            }
            String.color = droppedImage.color * 0.8f;
            Bottom.color = droppedImage.color * 0.8f;
        }
    }





    public void OnPointerExit(PointerEventData pointerEventData)
    {
        if (pointerEventData.pointerDrag == null) return;
        Bottom2.sprite = nowSpriteBottom2;
        if (nowSpriteBottom2 == null)
        {
            Bottom2.color = Vector4.zero;
        }
        else
        {
            Bottom2.color = OldImageBottom2 * 2f;
        }
        String.sprite = nowSpriteString;
        Bottom.sprite = nowSpriteBottom;
        if (nowSpriteString == null)
        {
            String.color = Vector4.zero;
            Bottom.color = Vector4.zero;
        }
        else
        {
            String.color = OldImageString * 2f;
            Bottom.color = Vector4.one;
        }
    }




    public void OnDrop(PointerEventData pointerEventData)
    {
        Image droppedImage = pointerEventData.pointerDrag.GetComponent<Image>();

        if (droppedImage.CompareTag("Glass") || droppedImage.CompareTag("Pipe")
            || droppedImage.CompareTag("Wood_M") || droppedImage.CompareTag("Wood_B"))
        {
            BottomCheck = true;
            if (droppedImage.CompareTag("Glass"))
            {
                BottomPicker = 1;
                Bottom2.sprite = ImageSet[0];
                if (StringPicker == 1)
                {
                    String.sprite = ImageSet[11];
                    Bottom.sprite = ImageSet[8];
                }
                if (StringPicker == 2)
                {
                    String.sprite = ImageSet[6];
                    Bottom.sprite = ImageSet[8];
                }
            }
            if (droppedImage.CompareTag("Pipe"))
            {
                BottomPicker = 2;
                Bottom2.sprite = ImageSet[1];
                if (StringPicker == 1)
                {
                    String.sprite = ImageSet[5];
                    Bottom.sprite = ImageSet[9];
                }
                if (StringPicker == 2)
                {
                    String.sprite = ImageSet[7];
                    Bottom.sprite = ImageSet[10];
                }

            }
            if (droppedImage.CompareTag("Wood_M"))
            {
                BottomPicker = 3;
                Bottom2.sprite = ImageSet[2];
                if (StringPicker == 1)
                {
                    String.sprite = ImageSet[5];
                    Bottom.sprite = ImageSet[9];
                }
                if (StringPicker == 2)
                {
                    String.sprite = ImageSet[12];
                    Bottom.sprite = ImageSet[9];
                }
            }
            if (droppedImage.CompareTag("Wood_B"))
            {
                BottomPicker = 4;
                Bottom2.sprite = ImageSet[3];
                if (StringPicker == 1)
                {
                    String.sprite = ImageSet[4];
                    Bottom.sprite = ImageSet[8];
                }
                if (StringPicker == 2)
                {
                    String.sprite = ImageSet[6];
                    Bottom.sprite = ImageSet[8];
                }
            }
            nowSpriteBottom2 = Bottom2.sprite;
            OldImageBottom2 = droppedImage.color;
            Bottom2.color = droppedImage.color * 2;
            nowSpriteString = String.sprite;
            nowSpriteBottom = Bottom.sprite;
        }

        if (BottomCheck && droppedImage.CompareTag("String") || droppedImage.CompareTag("Nail"))
        {
            if (droppedImage.CompareTag("String"))
            {
                if (BottomPicker == 1)
                {
                    String.sprite = ImageSet[11];
                    Bottom.sprite = ImageSet[8];
                }
                if (BottomPicker == 4)
                {
                    String.sprite = ImageSet[4];
                    Bottom.sprite = ImageSet[8];
                }
                if (BottomPicker == 2)
                {
                    String.sprite = ImageSet[5];
                    Bottom.sprite = ImageSet[9];
                }
                if (BottomPicker == 3)
                {
                    String.sprite = ImageSet[5];
                    Bottom.sprite = ImageSet[9];
                }
                StringPicker = 1;
            }
            if (droppedImage.CompareTag("Nail"))
            {
                if (BottomPicker == 1)
                {
                    String.sprite = ImageSet[6];
                    Bottom.sprite = ImageSet[8];
                }
                if (BottomPicker == 4)
                {
                    String.sprite = ImageSet[6];
                    Bottom.sprite = ImageSet[8];
                }
                if (BottomPicker == 2)
                {
                    String.sprite = ImageSet[7];
                    Bottom.sprite = ImageSet[10];
                }
                if (BottomPicker == 3)
                {
                    String.sprite = ImageSet[12];
                    Bottom.sprite = ImageSet[9];
                }
                StringPicker = 2;
            }
            nowSpriteString = String.sprite;
            nowSpriteBottom = Bottom.sprite;
            OldImageString = droppedImage.color;
            String.color = droppedImage.color * 2f;
            Bottom.color = droppedImage.color * 2f;
        }
    }
}
