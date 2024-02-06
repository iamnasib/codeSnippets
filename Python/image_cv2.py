import cv2

#reading normal image
org_img=cv2.imread("M:/Nasib/nasib fav pics/IMG_20150412_124133.jpg")

cv2.imshow("Original Image",org_img)
cv2.waitKey()

#________ stage 2 greyscale

gray_img=cv2.cvtColor(org_img,cv2.COLOR_BGR2GRAY)
cv2.imshow("Greyscale",gray_img)
cv2.waitKey()

#________ stage 3 convert
cnvrtd_img=gray_convert=255-gray_img
cv2.imshow("converted",cnvrtd_img)
cv2.waitKey()

#gaussianblur
blurr=cv2.GaussianBlur(cnvrtd_img,(21,21),0)
invrtd=255-blurr
sketch_img=cv2.divide(gray_img,invrtd,scale=256.0)
cv2.imshow("sketch",sketch_img)
cv2.waitKey()



