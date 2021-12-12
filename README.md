# FarmBuild_Unity_Game
This game is built for completing the **C1 Cover-max** concept for game development projects for CS451. The stuudents are expected to refine these ideas into concrete specifications for their projects.

### C1 Cover-max 
A bounded 2D region D is said to be covered by a set of 2D items I if D is
a subset of the union of all the items in I. In other words, each point of D
is contained in the union of the items in I. The union of two 2D shapes is
simply the union of the points of the two shapes. Here, the number and the
shapes of the items of I are fixed. Also, D is given. The objective before the
player is to arrange the items in I so as to maximize the area covered. While
arranging an item of I, the player must be allowed all the rigid motions in
2D. No other transformation may be permitted.

## Our Idea - FarmBuild
### Backstory:
A Farmer in a village needs your help in his day to day chores. He is bad at
maths and figures and wants your help in order to systematize his work.
He wants you to help him figure out how to manage his space.
Everyday he gets up in the morning, brings his equipment out for work including
his sickle, spade, grape hoe etc. He has farms with given shapes and fixed
patterns in which he can grow crops. He cannot overlap the crops but wants to
maximize the profit by utilizing the maximum land possible. Now with the profit he
is making he will be able to buy new lands with different shapes in which he can
further cultivate and gain profits. But using land has its own price which degrades
and soil becomes less enriched with nutrients. So, we have to try to utilize as
much land as possible

### GOAL:
Our goal is to help the farmer maximize his profit and help him acquire more and
more land and at the end of the day help him put all his equipment back in the
garage.
All the points earned will be added in the coins which then later can be used to
buy a garage and land for farming. And later after a particular stage we can let
the farmer cut the given shape of the crop and plant it separately. But this power
will only be used for a given number of times and will cost some coins.
And later in one level the farmer won’t know the shape of the crops he can plant
earlier. He will be offered one by one each crop which he may choose to plant in
his farm or pass it and check the next one. He can plant it wherever he wants but
cannot shift it again.

### GAME PLAY:
We will be given a fixed shape(farm) which we have to populate using the bunch
of crops given to us and will be pre-known to us. The profit will be based on the
area covered by the crops of the total farm - the cost of using the land. And after
the user submits the pattern of crop planting we will add/subtract the amount
from the coins the user will be having.
After every such crop deciding process, the user has to put all his equipment
back to the garage but everytime the shape of the garage will change and the
user has to fit all the equipment back in it.
To make the user play this game for a longer time and not just quit it after one or
two runs, there will be a cost of bringing the equipment out of the garage so that
the user may think of playing it one more time before putting the equipment back
to the garage.

## Game Scene
![Main_Scene](https://user-images.githubusercontent.com/60234231/145712130-8642a2e4-bd47-4054-aea2-0260e2b8ea3e.png)
![text](https://user-images.githubusercontent.com/60234231/145713478-966c34f4-7c40-45b6-b80f-631122b583e0.PNG)
![Store_levels](https://user-images.githubusercontent.com/60234231/145713321-deada7c8-cbae-4621-ae5d-f045ff5274b3.PNG)
![Level1_Level2](https://user-images.githubusercontent.com/60234231/145712160-916155e1-3494-48d0-8b93-914c4ee2baca.png)
![Level3](https://user-images.githubusercontent.com/60234231/145712162-ba4ae5e9-57d4-45a8-a939-21d2a9b18990.png)
![Bonus_level](https://user-images.githubusercontent.com/60234231/145713338-7341fdae-ae40-4941-9871-609b16725849.PNG)
