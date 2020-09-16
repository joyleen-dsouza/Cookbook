using System.Collections.Generic;
using Xamarin.Forms;

namespace Cookbook.Model
{
    public class Receipe
    {
        public string Name { get; set; }
        public string Imageurl {get; set;}
        public string Ingredients { get; set; }
        public string Procedure { get; set; }

        public List<Receipe> GetDishes()
        {
            List<Receipe> dishes = new List<Receipe>()
            {
                new Receipe(){ Name="Chicken Biryani",
                               Imageurl= "chicken_biryani.jpg",
                               Ingredients="1 tbsp vegetable oil"+"\r\n"+
                                           "10 grams garlic " +"\r\n"+
                                           "10 grams ginger"+"\r\n"+
                                           "1 serrano chili peppers"+"\r\n"+
                                           "5 grams mint"+"\r\n"+
                                           "10 grams cilantro" +"\r\n"+
                                           "1 tbsp garam masala"+ "\r\n"+
                                           "1/2 tsp ground cinnamon"+"\r\n"+
                                           "1 tsp salt"+"\r\n"+
                                           "900 grams chicken "+"\r\n"+
                                            "2 1/2 tsp salt"+"\r\n"+
                                            "5 pods green cardamom"+"\r\n"+
                                            "1 tsp cumin seeds" +"\r\n"+ 
                                            "1 bay leaf" +"\r\n"+
                                            "360 grams basmati rice"+"\r\n"+ 
                                            "2 tbsp ghee"+"\r\n"+
                                            "2 medium onions"+"\r\n"+ 
                                            "1/2 tsp saffron threads"+"\r\n",
                               Procedure=">To marinate the chicken for the biryani, combine the vegetable oil, garlic, ginger, chili peppers, mint, cilantro, garam masala, cinnamon and salt in a large bowl and stir together. Add the chicken pieces and toss together making sure the chicken is thoroughly coated in the marinade. Allow the chicken to marinate for at least 1 hour or up to overnight."+"\r\n\r\n"+
                                          ">In a pot wide enough to hold the chicken in a single layer, add the ghee and onions and saute the onions until they are well caramelized (15-20 minutes). Transfer the caramelized onions to a bowl and set aside."+"\r\n\r\n"+
                                          ">While the onions caramelize, prepare the rice by washing in a strainer under cold running water until the water runs clear."+"\r\n\r\n"+
                                          ">To par-boil the rice, add the water, salt, cardamom, cumin and bay leaf to a pot and bring to a boil. Add the rice and boil for 7 minutes. Drain the rice."+"\r\n\r\n"+
                                          ">In the pot you caramelized the onions in, add the chicken in a single layer, skin-side down. Fry until golden brown on one side (about 5 minutes). Flip the chicken over and fry the other side until golden brown. Transfer the chicken back to the bowl you marinated it in."+"\r\n\r\n"+
                                          ">To assemble the biryani, add the saffron to the rice and toss to distribute evenly. Add half the rice mixture to the bottom of the pot you browned the chicken in."+"\r\n\r\n"+
                                          ">Top the rice with the chicken in a single layer."+"\r\n\r\n"+
                                          ">Top the chicken with an even layer of caramelized onions."+"\r\n\r\n"+
                                          ">Finish putting together the Biryani by adding the rest of the rice in an even layer. Cover the pot with a lid and put the pot on the stove over medium heat and set the timer for 20 minutes.When you can see steam escaping from under the lid, turn down the heat to low and continue cooking until the timer goes off and then turn off the heat."+"\r\n\r\n"+
                                          ">Without opening the lid, set the timer for another 10 minutes to steam the biryani. Mix the Chicken Biryani together and then transfer to a serving platter. Garnish with fresh cilantro."+"\r\n\r\n"+
                                          ">Chicken Biryani is ready to serve!"+"\r\n\r\n"},
                
                new Receipe(){ Name="Chicken Lollipop",
                               Imageurl= "chicken_lollipop.jpg",
                               Ingredients="6 full-size chicken wings" +"\r\n"+
                                            "2 cups oil" +"\r\n"+
                                            "2 tsp chilli powder" +"\r\n"+
                                            "2 tbsp ginger garlic paste" +"\r\n"+
                                            "1 tsp pepper" +"\r\n"+
                                            "1 tsp salt" +"\r\n"+
                                            "2 tbsp soya sauce" +"\r\n"+
                                            "½ cup flour" +"\r\n"+
                                            "½ cup cornflour" +"\r\n"+
                                            "1 tbsp chilli powder" +"\r\n"+
                                            "1 egg" +"\r\n"+
                                            "¼ cup water"+"\r\n",
                                 Procedure=">Add chilli powder, salt, ginger garlic paste, soya sauce and pepper to a bowl and mix until fully combined, set aside." +"\r\n\r\n"+
                                 ">Slice a full-size chicken wing into three parts along the joints. Discard the wing-tip" +"\r\n\r\n"+
                                 ">For the drummet, cut along the circumference of the thin end so that the bone and the meat are no longer connected. Then push down the meat so the drummet becomes a lollipop." +"\r\n\r\n"+
                                 ">For the winglet, separate where the two bones join, and also cut along the circumferences of both ends, so the bone and the meat are no longer connected. Take out the thinner bone, and push down the meat into one end of the thinner bone." +"\r\n\r\n"+
                                 ">Place the prepared chicken lollipops in the marinade. Stir and cover. Marinate in the fridge for at least 1 hour." +"\r\n\r\n"+
                                 ">Mix all batter ingredients until smooth without lumps." +"\r\n\r\n"+
                                 ">Dip the meat end of the chicken lollipops into the batter." +"\r\n\r\n"+
                                 ">In a medium-sized pot, heat the oil to 170˚C. Deep fry the chicken for 5 minutes or until the batter becomes golden brown and the chicken is cooked throughout"+"\r\n\r\n"+
                                 ">Chicken Lollipop is ready to serve!"+"\r\n\r\n" },
                
                new Receipe(){ Name="Chicken Sukka",
                               Imageurl= "chicken_sukka.jpg",
                               Ingredients="1 kg chicken" +"\r\n"+
                                            "4 large onions sliced" +"\r\n"+
                                            "2 large tomatoes sliced" +"\r\n"+
                                            "1\" ginger" +"\r\n"+
                                            "4-5 flakes garlic" +"\r\n"+
                                            "1-1 1/2 cup fresh coconut" +"\r\n"+
                                            "1/2 tsp turmeric powder" +"\r\n"+
                                            "3 tbsp oil" +"\r\n"+
                                            "2 tbsp chopped coriander" +"\r\n"+
                                            "4 cloves" +"\r\n"+
                                            "2\" cinnamon"+"\r\n"+
                                            "1 tsp pepper corns"+"\r\n"+
                                            "4 tsp coriander seeds"+"\r\n"+
                                            "1 tsp cumin seeds"+"\r\n"+
                                            "½ tsp mustard seeds"+"\r\n"+
                                            "8-10 kashmiri red chillies"+"\r\n",                       
                                 Procedure=">Prepare masala using pepper corns, coriander seeds, cumin seeds, mustard seeds, kashmiri red chillis,cloves, cinnamon slightly roasted and powdered" +"\r\n\r\n"+
                                 ">Heat oil in a kadhai, add cloves and cinnamon. When it crackles add the onions, sauté till light brown and then add sliced tomatoes." +"\r\n\r\n"+
                                 ">Add the chicken, salt and cook on high heat for few minutes. Now add crushed ginger, garlic and turmeric powder." +"\r\n\r\n"+
                                 ">Add powdered masala, when chicken is half done.Mix well and cook till chicken is tender." +"\r\n\r\n"+
                                 ">Mix well and cook till chicken is tender." +"\r\n\r\n"+
                                 ">Finally add grated coconut and sauté it for 2 minutes." +"\r\n\r\n"+
                                 ">Add lemon juice and garnish with chopped coriander leaves."+"\r\n\r\n"+
                                 ">Chicken Sukka is ready to serve!"+"\r\n\r\n"},

                new Receipe(){ Name="Fish Curry",
                               Imageurl= "fish_curry.jpg",
                               Ingredients="2 teaspoons Dijon mustard" +"\r\n"+
                                    "1 tsp ground black pepper" +"\r\n"+
                                    "½ tsp salt" +"\r\n"+
                                    "2 tbsp canola oil" +"\r\n"+
                                    "4 eaches white fish fillets" +"\r\n"+
                                    "1 onion, coarsely chopped" +"\r\n"+
                                    "4 cloves chopped garlic"+"\r\n"+
                                    "1\" chopped ginger" +"\r\n"+
                                    "5 eaches cashew halves" +"\r\n"+
                                    "1 tbsp canola oil" +"\r\n"+
                                    "2 tsp cayenne pepper" +"\r\n"+
                                    "½ tsp ground turmeric" +"\r\n"+
                                    "1 tsp ground cumin" +"\r\n"+
                                    "1 tsp ground coriander" +"\r\n"+
                                    "1 tsp salt" +"\r\n"+
                                    "1 tsp white sugar" +"\r\n"+
                                    "½ cup chopped tomato" +"\r\n"+
                                    "¼ cup vegetable broth" +"\r\n"+
                                    "¼ cup chopped fresh cilantro"+"\r\n",
                                Procedure=">Mix the mustard, pepper, 1/2 teaspoon salt, and canola oil in a shallow bowl. Add the fish fillets, turning to coat. Marinate the fish in the refrigerator for 30 minutes." +"\r\n\r\n"+
                                 ">Combine the onion, garlic, ginger, and cashews in a blender or food processor and pulse until the mixture forms a paste." +"\r\n\r\n"+
                                 ">Heat 1 tablespoon of canola oil in a skillet over medium-low heat. Stir in the prepared paste; cook and stir for a minute or two." +"\r\n\r\n"+
                                 ">Add the cayenne pepper, turmeric, cumin, coriander, 1 teaspoon salt, and sugar. Cook and stir for an additional five minutes. Stir in the chopped tomato and vegetable broth." +"\r\n\r\n"+
                                 ">Add the fish fillets to it. Top with the sauce, cover the skilet, and let it cook until the fish flakes easily with a fork, about 15 minutes. " +"\r\n\r\n"+
                                 ">Garnish with chopped cilantro."+"\r\n\r\n"+
                                 ">Fish Curry is ready to serve!"+"\r\n\r\n"},
                
                new Receipe(){ Name="Fish Fry",
                               Imageurl= "fish_fry.jpg",
                               Ingredients="5 to 6 pieces fish" +"\r\n"+
                                            "2 tsp red chilli powder" +"\r\n"+
                                            "1/2 tsp coriander powder " +"\r\n"+
                                            "1/2 tsp turmeric powder" +"\r\n"+
                                            "1 tsp lime juice" +"\r\n"+
                                            "1 tsp Salt " +"\r\n"+
                                            "2 tbsp Oil"+"\r\n",
                                Procedure=">Clean fish and wash it twice to thrice. Set aside." +"\r\n\r\n"+
                                 ">In a wide mixing bowl, add red chilli, turmeric powder, coriander powder, lime juice and required salt. Sprinkle a little water to make a paste-like consistency." +"\r\n\r\n"+
                                 ">Then add the fish and mix well.Coat the masala on all sides of the fish and marinate for at least 30 mins." +"\r\n\r\n"+
                                 ">Heat oil in a pan or dosa tawa and fry the fish until the fish turns dark brown in colour."+"\r\n\r\n"+
                                 ">Fish Fry is ready to serve!"+"\r\n\r\n"},

                new Receipe(){ Name="Mutton Biryani",
                               Imageurl= "mutton_biryani.jpg",
                               Ingredients="2 cups Basmati Rice" +"\r\n"+
                                           "10g Potli Masala " +"\r\n"+
                                           "1 tsp Ghee" +"\r\n"+
                                           "1 tsp Shahi Zeera" +"\r\n"+
                                           "4 tsp Salt" +"\r\n"+
                                           "2 tsp Ginger Garlic Paste" +"\r\n"+
                                           "2 tsp Green Chilli Paste" +"\r\n"+
                                           "2-3 drops Kewra Essence" +"\r\n"+
                                           "750 grams Mutton" +"\r\n"+
                                           "Raw papaya paste" +"\r\n"+
                                           "2 tsp Ginger paste" +"\r\n"+
                                           "2 tsp Garlic paste" +"\r\n"+
                                           "2 tsp Green chili paste " +"\r\n"+
                                           "1/2 tsp Garam masala powder" +"\r\n"+
                                           "2 tsp Red Chilli powder" +"\r\n"+
                                           "1 tsp Turmeric powder" +"\r\n"+
                                           "2 tsp Salt" +"\r\n"+
                                           "2 tbsp Ghee" +"\r\n"+
                                           "2 tbsp Lemon juice" +"\r\n"+
                                           "200 grams Curd" +"\r\n"+
                                           "2 tbsp chopped Mint" +"\r\n"+
                                           "2 tbsp chopped Coriander" +"\r\n"+
                                           "1/4 cup Golden fried onion"+"\r\n",
                                Procedure=">Wash the rice and soak in water for 40-45 minutes." +"\r\n\r\n"+
                                 ">Tie whole spices in a cloth piece to make a potli." +"\r\n\r\n"+
                                 ">Mix mutton with raw papaya paste, ginger paste, garlic paste, garam masala powder, red chili powder, turmeric powder, salt, vegetable oil, green chili paste, and lemon juice and marinate for 8-10 hours." +"\r\n\r\n"+
                                 ">Add curd, mint, coriander, and golden fried onion in the marinated mutton and mix well."+"\r\n\r\n"+
                                 ">Heat water in a large pot. Add potli masala, salt, ginger-garlic paste, green chili paste, kewra essence, and shahi jeera in the pot and bring the water to a boil." +"\r\n\r\n"+
                                 ">Drain the rice and add it to the boiling water." +"\r\n\r\n"+
                                 ">Transfer the mutton along with the marinade in a heavy bottom pan." +"\r\n\r\n"+
                                 ">Once the rice gets 80% cooked, drain it and top it over the mutton." +"\r\n\r\n"+
                                 ">Sprinkle 1/2 cup milk, saffron soaked in water, golden brown onion and ghee on top. I also like to sprinkle chopped coriander and mint sometimes." +"\r\n\r\n"+
                                 ">Cover the pan tightly with a lid. Place the pan on a very slow heat for 50-55 minutes. Remove the lid and mix the biryani gently." +"\r\n\r\n"+
                                 ">Mutton Biryani is ready to serve!"+"\r\n\r\n"},

                new Receipe(){ Name="Palak Paneer",
                               Imageurl= "palak_paneer.jpg",
                               Ingredients="500 grams spinach, pureed" +"\r\n"+
                                           "15-16 Paneer cubes" +"\r\n"+
                                           "2 tbsp oil" +"\r\n"+
                                           "1 tsp cumin seeds" +"\r\n"+
                                           "1 Bay leaf" +"\r\n"+
                                           "1 tsp chopped ginger" +"\r\n"+
                                           "1 tsp chopped garlic" +"\r\n"+
                                           "1 cup boiled onion paste" +"\r\n"+
                                           "1/2 cup tomato, pureed" +"\r\n"+
                                           "2 tsp salt" +"\r\n"+
                                           "1/2 tsp garam masala" +"\r\n"+
                                           "1/2 tsp red pepper" +"\r\n"+
                                           "1/2 tsp coriander powder" +"\r\n"+
                                           "2 black crushed cardamom" +"\r\n"+
                                           "1 tbsp cream"+"\r\n",
                               Procedure=">Boil spinach in a pressure cooker and grind it to make palak puree." +"\r\n\r\n"+
                                 ">Heat oil in a pan and fry paneer cubes in it until golden brown." +"\r\n\r\n"+
                                 ">Remove the paneer cubes and put cumin, when it splutters, add bay leaf." +"\r\n\r\n"+
                                 ">When it starts to crackle add ginger, garlic and onion paste. Cook until it gets pinkish-brown in color."+"\r\n\r\n"+
                                 ">Add salt, garam masala, coriander powder along with red pepper. Stir till well mixed." +"\r\n\r\n"+
                                 ">Now add tomato puree and stir fry over medium heat." +"\r\n\r\n"+
                                 ">Add spinach and saute for 2-3 minutes." +"\r\n\r\n"+
                                 ">Now add paneer cubes to the mix and turn around a few times to completely mix it with the palak gravy." +"\r\n\r\n"+
                                 ">Pour some cream over and mix well " +"\r\n\r\n"+
                                 ">Palak Paneer is ready to serve!"+"\r\n\r\n"},

                new Receipe(){ Name="Aloo Gobi",
                               Imageurl= "aloo_gobi.jpg",
                               Ingredients="2 tablespoon vegetable oil" +"\r\n"+
                                       "1 red chili, diced" +"\r\n"+
                                       "2 cloves garlic, minced" +"\r\n"+
                                       "1 tbsp minced ginger" +"\r\n"+
                                       "1 tsp garam masala" +"\r\n"+
                                       "1/2 tsp dried turmeric" +"\r\n"+
                                       "1/4 tsp cayenne pepper" +"\r\n"+
                                       "3 chopped potatoes" +"\r\n"+
                                       "1 cauliflower, cut into florets" +"\r\n"+
                                       "1 c. low-sodium vegetable broth" +"\r\n"+
                                       "Kosher salt" +"\r\n"+
                                       "Freshly ground black pepper" +"\r\n"+
                                       "Freshly chopped cilantro"+"\r\n",
                               Procedure=">In a large skillet over medium-high heat, heat oil. Add chili, garlic, and ginger and cook until fragrant, 1 minute." +"\r\n\r\n"+
                                 ">Add garam masala, turmeric, and cayenne and cook until toasted, 1 minute more." +"\r\n\r\n"+
                                 ">Add potatoes, cauliflower, and vegetable broth and season with salt and pepper." +"\r\n\r\n"+
                                 ">Reduce heat and cook, covered, until potatoes and cauliflower are tender, 15 minutes. Garnish with cilantro."+"\r\n\r\n"+
                                 ">Aloo Gobi is ready to serve!" +"\r\n\r\n"},

                new Receipe(){ Name="Gobi Manchurian",
                               Imageurl= "gobi_manchurian.jpg",
                               Ingredients="3 cups small florets of Cauliflower" +"\r\n"+
                                            "6 tbsp Maida" +"\r\n"+
                                            "4 tbsp Cornflour" +"\r\n"+
                                            "1 Egg" +"\r\n"+
                                            "1 tsp Ginger Garlic Paste" +"\r\n"+
                                            "Salt to taste" +"\r\n"+
                                            "1/2 tsp Chilli Sauce" +"\r\n"+
                                            "3 tbsp Dark Soya Sauce" +"\r\n"+
                                            "1 tsp Pepper Powder" +"\r\n"+
                                            "2 tbsp Oil" +"\r\n"+
                                            "1 tsp finely chopped Ginger" +"\r\n"+
                                            "1 tbsp finely chopped Garlic" +"\r\n"+
                                            "2 Green Chillies" +"\r\n"+
                                             "1/2 cup Onion" +"\r\n"+
                                             "1/2 cup Capsicum" +"\r\n"+
                                             "1 tsp Vinegar" +"\r\n"+
                                             "1 tsp Chilli Paste" +"\r\n"+
                                             "2 tsp Red Chilli sauce" +"\r\n"+
                                             "2 tsp Tomato sauce" +"\r\n"+
                                             "3 tbsp Spring Onion Greens"+"\r\n",
                               Procedure=">Blanch the cauliflower florets in hot water for 2 minutes." +"\r\n\r\n"+
                                 ">For the batter, combine maida, cornflour, egg, ginger garlic paste, salt, chilli sauce, 1/2 tsp soy sauce, 1/2 tsp pepper powder and enough water to make a coating consistency medium thick batter." +"\r\n\r\n"+
                                 ">Dip the cauliflower florets in it and deep fry them in hot oil on medium high heat till crisp and golden brown in colour." +"\r\n\r\n"+
                                 ">To prepare the sauce, heat oil in a pan and add chopped ginger and garlic. Saute them for just few seconds." +"\r\n\r\n"+
                                 ">Add green chillies and onion, saute them for one more minute.Add capsicum and fry for one more minute." +"\r\n\r\n"+
                                 ">Combine rest of the soy sauce, vinegar, chilli paste and red chilli sauce, tomato sauce, sugar, salt and pepper in a bowl and add it to the pan. Add little water and bring it to boil"+"\r\n\r\n"+
                                 ">Add the fried cauliflower florets to the sauce and toss well.Switch off the heat and sprinkle spring onion greens on it." +"\r\n\r\n"+
                                 ">Gobi Manchurian is ready to serve!"+"\r\n"},

                new Receipe(){ Name="Dal Fry",
                               Imageurl= "dal_fry.jpg",
                               Ingredients="1 cup Tur Dal" +"\r\n"+
                                            "3 finely chopped Tomatoes" +"\r\n"+
                                            "1/2 tsp Turmeric Powder" +"\r\n"+
                                            "1 tsp Salt" +"\r\n"+
                                            "2 tbsp Butter" +"\r\n"+
                                            "1 tbsp Ghee" +"\r\n"+
                                            "1 tsp Mustard Seeds" +"\r\n"+
                                            "1 tsp Cumin Seeds" +"\r\n"+
                                            "6 smashed whole Garlic Cloves" +"\r\n"+
                                            "8-10 Curry Leaves" +"\r\n"+
                                            "2 Green Chillies" +"\r\n"+
                                            "2 Whole dried Red Chillies" +"\r\n"+
                                            "1/2 tsp Chilli Powder" +"\r\n"+
                                            "2 tbsp Cilantro"+"\r\n",
                               Procedure=">Pressure cook the dal with tomatoes, turmeric, salt and 3 cups water till completely cooked through and can be mashed easily between two fingers." +"\r\n\r\n"+
                                 ">Heat ghee and butter in a pan and add the smashed garlic. Stir fry on high for a minute till the garlic is fragrant and starts turning golden brown. " +"\r\n\r\n"+
                                 ">Reduce the heat and add mustard seeds, cumin seeds, curry leaves, green and red chillies and stir fry for another minute." +"\r\n\r\n"+
                                 ">Add red chilli powder and give it a quick stir and all the cooked dal along with 1/2 cup water. Bring this to a boil and simmer for five minutes." +"\r\n\r\n"+
                                 ">Switch off the flame and stir in cilantro " +"\r\n\r\n"+
                                 ">Dal Fry is ready to serve!"+"\r\n\r\n"},

                new Receipe(){ Name="Carrot Halwa",
                               Imageurl= "carrot_halwa.jpg",
                               Ingredients="8-9 tender juicy carrots" +"\r\n"+
                                            "4 cups full fat milk" +"\r\n"+
                                            "4 tbsp ghee" +"\r\n"+
                                            "10-12 tbsp regular sugar" +"\r\n"+
                                            "1 tsp cardamom powder" +"\r\n"+
                                            "10-12 chopped cashews" +"\r\n"+
                                            "10-12 chopped almonds" +"\r\n"+
                                            "2 tbsp golden raisins" +"\r\n"+
                                            "1 pinch saffron strands"+"\r\n",
                               Procedure=">In a kadai combine milk and grated carrots." +"\r\n\r\n"+
                                 ">On a low to medium flame, bring the whole mixture to a boil and then simmer. Keep stirring in between." +"\r\n\r\n"+
                                 ">The grated carrots will cook in the milk and when the milk has 75% reduced, add the ghee, sugar and powdered cardamom to the mixture." +"\r\n\r\n"+
                                 ">Towards the end, add the cashews, almonds, saffron and raisins. Simmer the halwa till all the milk is evaporated. Switch off the burner. " +"\r\n\r\n"+
                                 ">Carrot Halwa is ready to serve!"+"\r\n\r\n"},

                new Receipe(){ Name="Gulab Jamun",
                               Imageurl= "gulab_jamun.jpg",
                               Ingredients ="2 cups Sugar" +"\r\n"+
                                            "5 cups Water" +"\r\n"+
                                            "1 tsp Milk" +"\r\n"+
                                            "1/4 tsp Cardamom Seeds" +"\r\n"+
                                            "1/2 tsp Saffron" +"\r\n"+
                                            "1/2 tsp Cardamom Powder" +"\r\n"+
                                            "1 1/2 cups grated Khoya" +"\r\n"+
                                            "1/2 tsp Baking Soda" +"\r\n"+
                                            "1/2 cup Maida" +"\r\n"+
                                            "1 tsp Milk"+"\r\n",
                               Procedure=">Take sugar and water in a deep pan. Stir and bring to boil on high flame for sugar to dissolve." +"\r\n\r\n"+
                                 ">Now add milk and cardamom seeds to the sugar water. Boil further and strain." +"\r\n\r\n"+
                                 ">Then add saffron and cardamom powder and bring the mixture to rolling boil for about 5-6 minutes until it becomes little sticky." +"\r\n\r\n"+
                                 ">Take the grated Khoya in a medium size deep bowl.Add baking soda and maida. Combine them thoroughly but gently using a spoon." +"\r\n\r\n"+
                                 ">Add a teaspoon of milk to it and knead all of them together to make a smooth and soft dough. Add another teaspoon of milk if required." +"\r\n\r\n"+
                                 ">Make sure that the dough is a bit softer to avoid cracking of ball while deep frying.Divide the dough into equal parts and make smooth surfaced balls out of it."+"\r\n\r\n"+
                                 ">Now heat ghee in a pan over medium flame and add the Jamun balls to deep-fry them. Cook evenly until it becomes golden brown." +"\r\n\r\n"+
                                 ">Drain and let them cool for few minutes.Then immerse the gulab jamuns in the warm sugar syrup for at least 30 minutes."+"\r\n\r\n"+
                                 ">Gulab Jamun is ready to serve!" +"\r\n\r\n"},

                new Receipe(){ Name="Rasmalai",
                               Imageurl= "ras_malai.jpg",
                               Ingredients="5 cups full-fat milk" +"\r\n"+
                                            "1/2 tsp saffron strands" +"\r\n"+
                                            "1 tsp cornflour"+"\r\n"+
                                            "1 1/4 cup sugar" +"\r\n"+
                                            "1/2 tbsp cardamom powder" +"\r\n"+
                                            "1 1/2 tbsp lemon juice" +"\r\n"+
                                            "1 tbsp pistachio silvers" +"\r\n"+
                                            "1 almond silvers"+"\r\n",
                               Procedure=">Boil milk in a heavy bottom pan.Once it comes to a boil, switch off the flame and add 1/2 cup of water to bring the temperature of the milk down a bit." +"\r\n\r\n"+
                                          ">Wait for 5 - 10 minutes and then start adding lemon juice till milk curdles.Add lemon juice till the milk curdles completely." +"\r\n\r\n"+
                                          ">Using a strainer drain the water and collect the chena.Rinse it under tap water so that there's no trace of lemon juice in it." +"\r\n\r\n"+
                                          ">Leave it in the strainer for 10 - 15 minutes and then take the chena in your hand and squeeze out remaining water slowly." +"\r\n\r\n"+
                                          ">Add cornflour and start mashing the chena till it’s smooth.Set the clock to 10 minutes and mash constantly for 10 minutes using your palm. Once it’s smooth, make small balls out of it." +"\r\n\r\n"+
                                          ">Heat 1 cup sugar and 4 cups water in a wide pan and wait till it comes to a full boil." +"\r\n\r\n"+
                                          ">Drop the balls in boiling sugar syrup and cook for 15 - 17 minutes.The balls will double in size by then." +"\r\n\r\n"+
                                          ">Take out the balls from the syrup and drop them in fresh water.If they sink to the bottom, the balls are done." +"\r\n\r\n"+
                                          ">In a heavy bottom pan, boil 500 ml of milk.Once the milk comes to a boil, lower the flame and continue to stir the milk at regular intervals.After 10 minutes add sugar and mix." +"\r\n\r\n"+
                                          ">Soak few strands of saffron in a tablespoon of warm milk and set aside.After 20 - 25 minutes the milk will thicken to desired consistency, add soaked saffron and crushed cardamom.Also add finely chopped pistachios." +"\r\n\r\n"+
                                          ">Mix and switch off the flame.Take out the cooled rasmalai balls from the sugar syrup, squeeze and flatten with your hands." +"\r\n\r\n"+
                                          ">Transfer the balls to thickened warm milk.Chill for 5 - 6 hours.Garnish with chopped pistachios and few saffron strands." +"\r\n\r\n"+
                                          ">Rasmalai is ready to serve!" +"\r\n\r\n" },

                new Receipe(){ Name="Milk Peda",
                               Imageurl= "milk_peda.jpg",
                               Ingredients="5 cup milk" +"\r\n"+
                                            "¼ cup sugar" +"\r\n"+
                                            "¼ tsp cardamom powder"+"\r\n",
                               Procedure=">Firstly, in a large kadai take 5 cup milk." +"\r\n\r\n"+
                               ">Stir occasionally to prevent milk from sticking to the bottom and burning and get the milk to a boil.Stir continuously, and the milk thickens in 8 minutes." +"\r\n\r\n"+
                               ">After 30 minutes, the milk turns creamy texture. Keep stirring on low flame, to prevent milk from burning.After 50 minutes, it turns to a paste kinda texture." +"\r\n\r\n"+
                               ">Now add sugar. Keep stirring till the sugar dissolves. Continue to cook on low flame until the mixture separates from the pan and holds shape." +"\r\n\r\n"+
                               ">Cool slightly and take a small sized ball. Roll to a ball and design using the mould." +"\r\n\r\n"+
                               ">Milk peda is ready to serve! "+"\r\n\r\n" },

                new Receipe(){ Name="Coconut Laddoo",
                               Imageurl= "coconut_laddoo.jpg",
                               Ingredients="1/2 Cup Khoya" +"\r\n"+
                                            "1 tsp Ghee" +"\r\n"+
                                            "10-15 Cashews" +"\r\n"+
                                            "10-15 Almonds" +"\r\n"+
                                            "1 1/2 Cup Dessicated Coconut" +"\r\n"+
                                            "1 Cup Condensed Milk"+"\r\n",
                               Procedure="Take khoya in a pan and saute it well to melt it and form a paste."+"\r\n\r\n"+
                                          "Now take some ghee in the pan and roast cashews followed by almonds till golden brown."+"\r\n\r\n"+
                                          "Take dessicated coconut in a pan and saute it till light brown and add condensed milk. Mix them well to form a thick paste. Add khoya paste and mix well."+"\r\n\r\n"+
                                          "Make small round balls of the paste and put roasted cashews and almonds inside the coconut ball. Roll the coconut balls in the roasted dessicated coconut."+"\r\n\r\n"+
                                          "Coconut Laddoo is ready to serve!" +"\r\n\r\n" },    

            };
            return dishes;
        }
    }
}
