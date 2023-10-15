using NpcD = NpcDialogPart;

class Dialogs
{
    public static NpcDialogPart Dialog1 = new NpcDialogPart(
        "Hi, could you help me get to the next town?", new[] {
            new HeroDialogPart("Yeah, with pleasure",
                new NpcDialogPart("Thank you! As a reward I'll give you 100 gold", new[] {
                        new HeroDialogPart("I'll notify you when I'm ready", null),
                        new HeroDialogPart("100 gold is not enough!",
                            new NpcDialogPart("I am very poor, I do not have more money", new[] {
                                    new HeroDialogPart("OK, my loss, 100 gold will do",
                                        new NpcDialogPart("Thank you", null)
                                    ),
                                    new HeroDialogPart("Then deal with it yourself", null)
                                }
                            )
                        )
                    }
                )
            ),
            new HeroDialogPart("No, I'll not, bye", null)
        }
    );

    public static NpcDialogPart Dialog2 = new NpcDialogPart(
        "Oi! Aren't you the faumous dragon slayer #HERONAME#?!", new[] {
            new HeroDialogPart("Yes, I am #HERONAME#",
                new NpcDialogPart("WOW! It's an honour to meet you!", null)
            ),
            new HeroDialogPart("No.", null)
        }
    );
}
