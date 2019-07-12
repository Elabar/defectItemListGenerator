# Defect Item List Generator

Purpose: To generate a formated excel file without hassle.
<br>
<br>
Format Sample:
<br>
![alt text](https://user-images.githubusercontent.com/15872787/61143018-b44de700-a503-11e9-8b51-c9cf5484765b.png)
<br>
<br>
Program layout:
<br>
![alt text](https://user-images.githubusercontent.com/15872787/61150068-18c57200-a515-11e9-8098-84e1a5789bd5.png)
<br>
<br>
Usage:
1. Create a parent directory as the source folder.
2. Create sub directory inside the created source folder. (Each sub directory is equivalent to an item or a row)
3. Save the images into the sub directory.(Only accept 4 images for one row, image extension is restricted to .jpg only)
4. Save a .txt file for each sub directory. Inside the txt file, 1 line is equivalent to 1 description for 1 image.

*Step 3 and 4 are optional.
<br>
*Image order is followed by the name in ascending order.
<br>
*Lines in txt file are first come first serve.If you want a description for the first image in this directory, put it as the first line in the txt file.
<br>
<br>
Future to-do list: (Whole project may be abandoned tho)
1. Accept all image extention.
2. Infinite image in one row and the format should change accordingly.
3. Fill in the remark section with the txt file in each sub directory.
