# Using C#, format decimal scale factor/value to the imperial representation using feet, inches and fraction

**Sample output by this project:**

DECIMAL INCH VALUE TO IMPERIAL REPRESENTATION:
Subdivisions: 64 (default)

  1. FormatInchesInImperial((0.1)
     3/32"

  2. FormatInchesInImperial((0.2)
     13/64"

  3. FormatInchesInImperial((0.3)
     19/64"

  4. FormatInchesInImperial((0.4)
     13/32"

  5. FormatInchesInImperial((0.5)
     1/2"

  6. FormatInchesInImperial((0.6)
     19/32"

  7. FormatInchesInImperial((0.7)
     45/64"

  8. FormatInchesInImperial((0.8)
     51/64"

  9. FormatInchesInImperial((0.9)
     29/32"

 10. FormatInchesInImperial((1)
     1"

 11. FormatInchesInImperial((1.1)
     1 3/32"

 12. FormatInchesInImperial((1.2)
     1 13/64"

 13. FormatInchesInImperial((1.3)
     1 19/64"

 14. FormatInchesInImperial((1.4)
     1 13/32"

 15. FormatInchesInImperial((1.5)
     1 1/2"

 16. FormatInchesInImperial((1.6)
     1 19/32"

 17. FormatInchesInImperial((1.7)
     1 45/64"

 18. FormatInchesInImperial((1.8)
     1 51/64"

 19. FormatInchesInImperial((1.9)
     1 29/32"

 20. FormatInchesInImperial((2)
     2"

 21. FormatInchesInImperial((2.1)
     2 3/32"

 22. FormatInchesInImperial((2.2)
     2 13/64"

 23. FormatInchesInImperial((2.3)
     2 19/64"

 24. FormatInchesInImperial((2.4)
     2 13/32"

 25. FormatInchesInImperial((2.5)
     2 1/2"

 26. FormatInchesInImperial((2.6)
     2 19/32"

 27. FormatInchesInImperial((2.7)
     2 45/64"

 28. FormatInchesInImperial((2.8)
     2 51/64"

 29. FormatInchesInImperial((2.9)
     2 29/32"

 30. FormatInchesInImperial((3)
     3"

 31. FormatInchesInImperial((3.1)
     3 3/32"

 32. FormatInchesInImperial((3.2)
     3 13/64"

 33. FormatInchesInImperial((3.3)
     3 19/64"

 34. FormatInchesInImperial((3.4)
     3 13/32"

 35. FormatInchesInImperial((3.5)
     3 1/2"

 36. FormatInchesInImperial((3.6)
     3 19/32"

 37. FormatInchesInImperial((3.7)
     3 45/64"

 38. FormatInchesInImperial((3.8)
     3 51/64"

 39. FormatInchesInImperial((3.9)
     3 29/32"

 40. FormatInchesInImperial((4)
     4"

 41. FormatInchesInImperial((4.1)
     4 3/32"

 42. FormatInchesInImperial((4.2)
     4 13/64"

 43. FormatInchesInImperial((4.3)
     4 19/64"

 44. FormatInchesInImperial((4.4)
     4 13/32"

 45. FormatInchesInImperial((4.5)
     4 1/2"

 46. FormatInchesInImperial((4.6)
     4 19/32"

 47. FormatInchesInImperial((4.7)
     4 45/64"

 48. FormatInchesInImperial((4.8)
     4 51/64"

 49. FormatInchesInImperial((4.9)
     4 29/32"

 50. FormatInchesInImperial((5)
     5"

 51. FormatInchesInImperial((5.1)
     5 3/32"

 52. FormatInchesInImperial((5.2)
     5 13/64"

 53. FormatInchesInImperial((5.3)
     5 19/64"

 54. FormatInchesInImperial((5.4)
     5 13/32"

 55. FormatInchesInImperial((5.5)
     5 1/2"

 56. FormatInchesInImperial((5.6)
     5 19/32"

 57. FormatInchesInImperial((5.7)
     5 45/64"

 58. FormatInchesInImperial((5.8)
     5 51/64"

 59. FormatInchesInImperial((5.9)
     5 29/32"

 60. FormatInchesInImperial((6)
     6"

 61. FormatInchesInImperial((6.1)
     6 3/32"

 62. FormatInchesInImperial((6.2)
     6 13/64"

 63. FormatInchesInImperial((6.3)
     6 19/64"

 64. FormatInchesInImperial((6.4)
     6 13/32"

 65. FormatInchesInImperial((6.5)
     6 1/2"

 66. FormatInchesInImperial((6.6)
     6 19/32"

 67. FormatInchesInImperial((6.7)
     6 45/64"

 68. FormatInchesInImperial((6.8)
     6 51/64"

 69. FormatInchesInImperial((6.9)
     6 29/32"

 70. FormatInchesInImperial((7)
     7"

 71. FormatInchesInImperial((7.1)
     7 3/32"

 72. FormatInchesInImperial((7.2)
     7 13/64"

 73. FormatInchesInImperial((7.3)
     7 19/64"

 74. FormatInchesInImperial((7.4)
     7 13/32"

 75. FormatInchesInImperial((7.5)
     7 1/2"

 76. FormatInchesInImperial((7.6)
     7 19/32"

 77. FormatInchesInImperial((7.7)
     7 45/64"

 78. FormatInchesInImperial((7.8)
     7 51/64"

 79. FormatInchesInImperial((7.9)
     7 29/32"

 80. FormatInchesInImperial((8)
     8"

 81. FormatInchesInImperial((8.1)
     8 3/32"

 82. FormatInchesInImperial((8.2)
     8 13/64"

 83. FormatInchesInImperial((8.3)
     8 19/64"

 84. FormatInchesInImperial((8.4)
     8 13/32"

 85. FormatInchesInImperial((8.5)
     8 1/2"

 86. FormatInchesInImperial((8.6)
     8 19/32"

 87. FormatInchesInImperial((8.7)
     8 45/64"

 88. FormatInchesInImperial((8.8)
     8 51/64"

 89. FormatInchesInImperial((8.9)
     8 29/32"

 90. FormatInchesInImperial((9)
     9"

 91. FormatInchesInImperial((9.1)
     9 3/32"

 92. FormatInchesInImperial((9.2)
     9 13/64"

 93. FormatInchesInImperial((9.3)
     9 19/64"

 94. FormatInchesInImperial((9.4)
     9 13/32"

 95. FormatInchesInImperial((9.5)
     9 1/2"

 96. FormatInchesInImperial((9.6)
     9 19/32"

 97. FormatInchesInImperial((9.7)
     9 45/64"

 98. FormatInchesInImperial((9.8)
     9 51/64"

 99. FormatInchesInImperial((9.9)
     9 29/32"

100. FormatInchesInImperial((10)
     10"

101. FormatInchesInImperial((10.1)
     10 3/32"

102. FormatInchesInImperial((10.2)
     10 13/64"

103. FormatInchesInImperial((10.3)
     10 19/64"

104. FormatInchesInImperial((10.4)
     10 13/32"

105. FormatInchesInImperial((10.5)
     10 1/2"

106. FormatInchesInImperial((10.6)
     10 19/32"

107. FormatInchesInImperial((10.7)
     10 45/64"

108. FormatInchesInImperial((10.8)
     10 51/64"

109. FormatInchesInImperial((10.9)
     10 29/32"

110. FormatInchesInImperial((11)
     11"

111. FormatInchesInImperial((11.1)
     11 3/32"

112. FormatInchesInImperial((11.2)
     11 13/64"

113. FormatInchesInImperial((11.3)
     11 19/64"

114. FormatInchesInImperial((11.4)
     11 13/32"

115. FormatInchesInImperial((11.5)
     11 1/2"

116. FormatInchesInImperial((11.6)
     11 19/32"

117. FormatInchesInImperial((11.7)
     11 45/64"

118. FormatInchesInImperial((11.8)
     11 51/64"

119. FormatInchesInImperial((11.9)
     11 29/32"

120. FormatInchesInImperial((12)
     1'-0"

121. FormatInchesInImperial((12.1)
     1'-3/32"

122. FormatInchesInImperial((12.2)
     1'-13/64"

123. FormatInchesInImperial((12.3)
     1'-19/64"

124. FormatInchesInImperial((12.4)
     1'-13/32"

125. FormatInchesInImperial((12.5)
     1'-1/2"

126. FormatInchesInImperial((12.6)
     1'-19/32"

127. FormatInchesInImperial((12.7)
     1'-45/64"

128. FormatInchesInImperial((12.8)
     1'-51/64"

129. FormatInchesInImperial((12.9)
     1'-29/32"

130. FormatInchesInImperial((13)
     1'-1"

131. FormatInchesInImperial((13.1)
     1'-1 3/32"

132. FormatInchesInImperial((13.2)
     1'-1 13/64"

133. FormatInchesInImperial((13.3)
     1'-1 19/64"

134. FormatInchesInImperial((13.4)
     1'-1 13/32"

135. FormatInchesInImperial((13.5)
     1'-1 1/2"

136. FormatInchesInImperial((13.6)
     1'-1 19/32"

137. FormatInchesInImperial((13.7)
     1'-1 45/64"

138. FormatInchesInImperial((13.8)
     1'-1 51/64"

139. FormatInchesInImperial((13.9)
     1'-1 29/32"

140. FormatInchesInImperial((14)
     1'-2"

141. FormatInchesInImperial((14.1)
     1'-2 3/32"

142. FormatInchesInImperial((14.2)
     1'-2 13/64"

143. FormatInchesInImperial((14.3)
     1'-2 19/64"

144. FormatInchesInImperial((14.4)
     1'-2 13/32"

145. FormatInchesInImperial((14.5)
     1'-2 1/2"

146. FormatInchesInImperial((14.6)
     1'-2 19/32"

147. FormatInchesInImperial((14.7)
     1'-2 45/64"

148. FormatInchesInImperial((14.8)
     1'-2 51/64"

149. FormatInchesInImperial((14.9)
     1'-2 29/32"

150. FormatInchesInImperial((15)
     1'-3"

DECIMAL INCH VALUE TO IMPERIAL REPRESENTATION:
Subdivisions: 128

  1. FormatInchesInImperial((0.1)
     13/128"

  2. FormatInchesInImperial((0.2)
     13/64"

  3. FormatInchesInImperial((0.3)
     19/64"

  4. FormatInchesInImperial((0.4)
     51/128"

  5. FormatInchesInImperial((0.5)
     1/2"

  6. FormatInchesInImperial((0.6)
     77/128"

  7. FormatInchesInImperial((0.7)
     45/64"

  8. FormatInchesInImperial((0.8)
     51/64"

  9. FormatInchesInImperial((0.9)
     115/128"

 10. FormatInchesInImperial((1)
     1"

 11. FormatInchesInImperial((1.1)
     1 13/128"

 12. FormatInchesInImperial((1.2)
     1 13/64"

 13. FormatInchesInImperial((1.3)
     1 19/64"

 14. FormatInchesInImperial((1.4)
     1 51/128"

 15. FormatInchesInImperial((1.5)
     1 1/2"

 16. FormatInchesInImperial((1.6)
     1 77/128"

 17. FormatInchesInImperial((1.7)
     1 45/64"

 18. FormatInchesInImperial((1.8)
     1 51/64"

 19. FormatInchesInImperial((1.9)
     1 115/128"

 20. FormatInchesInImperial((2)
     2"

 21. FormatInchesInImperial((2.1)
     2 13/128"

 22. FormatInchesInImperial((2.2)
     2 13/64"

 23. FormatInchesInImperial((2.3)
     2 19/64"

 24. FormatInchesInImperial((2.4)
     2 51/128"

 25. FormatInchesInImperial((2.5)
     2 1/2"

 26. FormatInchesInImperial((2.6)
     2 77/128"

 27. FormatInchesInImperial((2.7)
     2 45/64"

 28. FormatInchesInImperial((2.8)
     2 51/64"

 29. FormatInchesInImperial((2.9)
     2 115/128"

 30. FormatInchesInImperial((3)
     3"

 31. FormatInchesInImperial((3.1)
     3 13/128"

 32. FormatInchesInImperial((3.2)
     3 13/64"

 33. FormatInchesInImperial((3.3)
     3 19/64"

 34. FormatInchesInImperial((3.4)
     3 51/128"

 35. FormatInchesInImperial((3.5)
     3 1/2"

 36. FormatInchesInImperial((3.6)
     3 77/128"

 37. FormatInchesInImperial((3.7)
     3 45/64"

 38. FormatInchesInImperial((3.8)
     3 51/64"

 39. FormatInchesInImperial((3.9)
     3 115/128"

 40. FormatInchesInImperial((4)
     4"

 41. FormatInchesInImperial((4.1)
     4 13/128"

 42. FormatInchesInImperial((4.2)
     4 13/64"

 43. FormatInchesInImperial((4.3)
     4 19/64"

 44. FormatInchesInImperial((4.4)
     4 51/128"

 45. FormatInchesInImperial((4.5)
     4 1/2"

 46. FormatInchesInImperial((4.6)
     4 77/128"

 47. FormatInchesInImperial((4.7)
     4 45/64"

 48. FormatInchesInImperial((4.8)
     4 51/64"

 49. FormatInchesInImperial((4.9)
     4 115/128"

 50. FormatInchesInImperial((5)
     5"

 51. FormatInchesInImperial((5.1)
     5 13/128"

 52. FormatInchesInImperial((5.2)
     5 13/64"

 53. FormatInchesInImperial((5.3)
     5 19/64"

 54. FormatInchesInImperial((5.4)
     5 51/128"

 55. FormatInchesInImperial((5.5)
     5 1/2"

 56. FormatInchesInImperial((5.6)
     5 77/128"

 57. FormatInchesInImperial((5.7)
     5 45/64"

 58. FormatInchesInImperial((5.8)
     5 51/64"

 59. FormatInchesInImperial((5.9)
     5 115/128"

 60. FormatInchesInImperial((6)
     6"

 61. FormatInchesInImperial((6.1)
     6 13/128"

 62. FormatInchesInImperial((6.2)
     6 13/64"

 63. FormatInchesInImperial((6.3)
     6 19/64"

 64. FormatInchesInImperial((6.4)
     6 51/128"

 65. FormatInchesInImperial((6.5)
     6 1/2"

 66. FormatInchesInImperial((6.6)
     6 77/128"

 67. FormatInchesInImperial((6.7)
     6 45/64"

 68. FormatInchesInImperial((6.8)
     6 51/64"

 69. FormatInchesInImperial((6.9)
     6 115/128"

 70. FormatInchesInImperial((7)
     7"

 71. FormatInchesInImperial((7.1)
     7 13/128"

 72. FormatInchesInImperial((7.2)
     7 13/64"

 73. FormatInchesInImperial((7.3)
     7 19/64"

 74. FormatInchesInImperial((7.4)
     7 51/128"

 75. FormatInchesInImperial((7.5)
     7 1/2"

 76. FormatInchesInImperial((7.6)
     7 77/128"

 77. FormatInchesInImperial((7.7)
     7 45/64"

 78. FormatInchesInImperial((7.8)
     7 51/64"

 79. FormatInchesInImperial((7.9)
     7 115/128"

 80. FormatInchesInImperial((8)
     8"

 81. FormatInchesInImperial((8.1)
     8 13/128"

 82. FormatInchesInImperial((8.2)
     8 13/64"

 83. FormatInchesInImperial((8.3)
     8 19/64"

 84. FormatInchesInImperial((8.4)
     8 51/128"

 85. FormatInchesInImperial((8.5)
     8 1/2"

 86. FormatInchesInImperial((8.6)
     8 77/128"

 87. FormatInchesInImperial((8.7)
     8 45/64"

 88. FormatInchesInImperial((8.8)
     8 51/64"

 89. FormatInchesInImperial((8.9)
     8 115/128"

 90. FormatInchesInImperial((9)
     9"

 91. FormatInchesInImperial((9.1)
     9 13/128"

 92. FormatInchesInImperial((9.2)
     9 13/64"

 93. FormatInchesInImperial((9.3)
     9 19/64"

 94. FormatInchesInImperial((9.4)
     9 51/128"

 95. FormatInchesInImperial((9.5)
     9 1/2"

 96. FormatInchesInImperial((9.6)
     9 77/128"

 97. FormatInchesInImperial((9.7)
     9 45/64"

 98. FormatInchesInImperial((9.8)
     9 51/64"

 99. FormatInchesInImperial((9.9)
     9 115/128"

100. FormatInchesInImperial((10)
     10"

101. FormatInchesInImperial((10.1)
     10 13/128"

102. FormatInchesInImperial((10.2)
     10 13/64"

103. FormatInchesInImperial((10.3)
     10 19/64"

104. FormatInchesInImperial((10.4)
     10 51/128"

105. FormatInchesInImperial((10.5)
     10 1/2"

106. FormatInchesInImperial((10.6)
     10 77/128"

107. FormatInchesInImperial((10.7)
     10 45/64"

108. FormatInchesInImperial((10.8)
     10 51/64"

109. FormatInchesInImperial((10.9)
     10 115/128"

110. FormatInchesInImperial((11)
     11"

111. FormatInchesInImperial((11.1)
     11 13/128"

112. FormatInchesInImperial((11.2)
     11 13/64"

113. FormatInchesInImperial((11.3)
     11 19/64"

114. FormatInchesInImperial((11.4)
     11 51/128"

115. FormatInchesInImperial((11.5)
     11 1/2"

116. FormatInchesInImperial((11.6)
     11 77/128"

117. FormatInchesInImperial((11.7)
     11 45/64"

118. FormatInchesInImperial((11.8)
     11 51/64"

119. FormatInchesInImperial((11.9)
     11 115/128"

120. FormatInchesInImperial((12)
     1'-0"

121. FormatInchesInImperial((12.1)
     1'-13/128"

122. FormatInchesInImperial((12.2)
     1'-13/64"

123. FormatInchesInImperial((12.3)
     1'-19/64"

124. FormatInchesInImperial((12.4)
     1'-51/128"

125. FormatInchesInImperial((12.5)
     1'-1/2"

126. FormatInchesInImperial((12.6)
     1'-77/128"

127. FormatInchesInImperial((12.7)
     1'-45/64"

128. FormatInchesInImperial((12.8)
     1'-51/64"

129. FormatInchesInImperial((12.9)
     1'-115/128"

130. FormatInchesInImperial((13)
     1'-1"

131. FormatInchesInImperial((13.1)
     1'-1 13/128"

132. FormatInchesInImperial((13.2)
     1'-1 13/64"

133. FormatInchesInImperial((13.3)
     1'-1 19/64"

134. FormatInchesInImperial((13.4)
     1'-1 51/128"

135. FormatInchesInImperial((13.5)
     1'-1 1/2"

136. FormatInchesInImperial((13.6)
     1'-1 77/128"

137. FormatInchesInImperial((13.7)
     1'-1 45/64"

138. FormatInchesInImperial((13.8)
     1'-1 51/64"

139. FormatInchesInImperial((13.9)
     1'-1 115/128"

140. FormatInchesInImperial((14)
     1'-2"

141. FormatInchesInImperial((14.1)
     1'-2 13/128"

142. FormatInchesInImperial((14.2)
     1'-2 13/64"

143. FormatInchesInImperial((14.3)
     1'-2 19/64"

144. FormatInchesInImperial((14.4)
     1'-2 51/128"

145. FormatInchesInImperial((14.5)
     1'-2 1/2"

146. FormatInchesInImperial((14.6)
     1'-2 77/128"

147. FormatInchesInImperial((14.7)
     1'-2 45/64"

148. FormatInchesInImperial((14.8)
     1'-2 51/64"

149. FormatInchesInImperial((14.9)
     1'-2 115/128"

150. FormatInchesInImperial((15)
     1'-3"

DECIMAL DECIMAL SCALE TO IMPERIAL REPRESENTATION:
Subdivisions: 64 (default)

  1. FormatScaleInImperial((0.1)
     1 13/64" = 1'-0"

  2. FormatScaleInImperial((0.2)
     2 13/32" = 1'-0"

  3. FormatScaleInImperial((0.3)
     3 19/32" = 1'-0"

  4. FormatScaleInImperial((0.4)
     4 51/64" = 1'-0"

  5. FormatScaleInImperial((0.5)
     6" = 1'-0"

  6. FormatScaleInImperial((0.6)
     7 13/64" = 1'-0"

  7. FormatScaleInImperial((0.7)
     8 13/32" = 1'-0"

  8. FormatScaleInImperial((0.8)
     9 19/32" = 1'-0"

  9. FormatScaleInImperial((0.9)
     10 51/64" = 1'-0"

 10. FormatScaleInImperial((1)
     1'-0" = 1'-0"

 11. FormatScaleInImperial((1.1)
     1'-1 13/64" = 1'-0"

 12. FormatScaleInImperial((1.2)
     1'-2 13/32" = 1'-0"

 13. FormatScaleInImperial((1.3)
     1'-3 19/32" = 1'-0"

 14. FormatScaleInImperial((1.4)
     1'-4 51/64" = 1'-0"

 15. FormatScaleInImperial((1.5)
     1'-6" = 1'-0"

 16. FormatScaleInImperial((1.6)
     1'-7 13/64" = 1'-0"

 17. FormatScaleInImperial((1.7)
     1'-8 13/32" = 1'-0"

 18. FormatScaleInImperial((1.8)
     1'-9 19/32" = 1'-0"

 19. FormatScaleInImperial((1.9)
     1'-10 51/64" = 1'-0"

 20. FormatScaleInImperial((2)
     2'-0" = 1'-0"

 21. FormatScaleInImperial((2.1)
     2'-1 13/64" = 1'-0"

 22. FormatScaleInImperial((2.2)
     2'-2 13/32" = 1'-0"

 23. FormatScaleInImperial((2.3)
     2'-3 19/32" = 1'-0"

 24. FormatScaleInImperial((2.4)
     2'-4 51/64" = 1'-0"

 25. FormatScaleInImperial((2.5)
     2'-6" = 1'-0"

 26. FormatScaleInImperial((2.6)
     2'-7 13/64" = 1'-0"

 27. FormatScaleInImperial((2.7)
     2'-8 13/32" = 1'-0"

 28. FormatScaleInImperial((2.8)
     2'-9 19/32" = 1'-0"

 29. FormatScaleInImperial((2.9)
     2'-10 51/64" = 1'-0"

 30. FormatScaleInImperial((3)
     3'-0" = 1'-0"

 31. FormatScaleInImperial((3.1)
     3'-1 13/64" = 1'-0"

 32. FormatScaleInImperial((3.2)
     3'-2 13/32" = 1'-0"

 33. FormatScaleInImperial((3.3)
     3'-3 19/32" = 1'-0"

 34. FormatScaleInImperial((3.4)
     3'-4 51/64" = 1'-0"

 35. FormatScaleInImperial((3.5)
     3'-6" = 1'-0"

 36. FormatScaleInImperial((3.6)
     3'-7 13/64" = 1'-0"

 37. FormatScaleInImperial((3.7)
     3'-8 13/32" = 1'-0"

 38. FormatScaleInImperial((3.8)
     3'-9 19/32" = 1'-0"

 39. FormatScaleInImperial((3.9)
     3'-10 51/64" = 1'-0"

 40. FormatScaleInImperial((4)
     4'-0" = 1'-0"

 41. FormatScaleInImperial((4.1)
     4'-1 13/64" = 1'-0"

 42. FormatScaleInImperial((4.2)
     4'-2 13/32" = 1'-0"

 43. FormatScaleInImperial((4.3)
     4'-3 19/32" = 1'-0"

 44. FormatScaleInImperial((4.4)
     4'-4 51/64" = 1'-0"

 45. FormatScaleInImperial((4.5)
     4'-6" = 1'-0"

 46. FormatScaleInImperial((4.6)
     4'-7 13/64" = 1'-0"

 47. FormatScaleInImperial((4.7)
     4'-8 13/32" = 1'-0"

 48. FormatScaleInImperial((4.8)
     4'-9 19/32" = 1'-0"

 49. FormatScaleInImperial((4.9)
     4'-10 51/64" = 1'-0"

 50. FormatScaleInImperial((5)
     5'-0" = 1'-0"

 51. FormatScaleInImperial((5.1)
     5'-1 13/64" = 1'-0"

 52. FormatScaleInImperial((5.2)
     5'-2 13/32" = 1'-0"

 53. FormatScaleInImperial((5.3)
     5'-3 19/32" = 1'-0"

 54. FormatScaleInImperial((5.4)
     5'-4 51/64" = 1'-0"

 55. FormatScaleInImperial((5.5)
     5'-6" = 1'-0"

 56. FormatScaleInImperial((5.6)
     5'-7 13/64" = 1'-0"

 57. FormatScaleInImperial((5.7)
     5'-8 13/32" = 1'-0"

 58. FormatScaleInImperial((5.8)
     5'-9 19/32" = 1'-0"

 59. FormatScaleInImperial((5.9)
     5'-10 51/64" = 1'-0"

 60. FormatScaleInImperial((6)
     6'-0" = 1'-0"

 61. FormatScaleInImperial((6.1)
     6'-1 13/64" = 1'-0"

 62. FormatScaleInImperial((6.2)
     6'-2 13/32" = 1'-0"

 63. FormatScaleInImperial((6.3)
     6'-3 19/32" = 1'-0"

 64. FormatScaleInImperial((6.4)
     6'-4 51/64" = 1'-0"

 65. FormatScaleInImperial((6.5)
     6'-6" = 1'-0"

 66. FormatScaleInImperial((6.6)
     6'-7 13/64" = 1'-0"

 67. FormatScaleInImperial((6.7)
     6'-8 13/32" = 1'-0"

 68. FormatScaleInImperial((6.8)
     6'-9 19/32" = 1'-0"

 69. FormatScaleInImperial((6.9)
     6'-10 51/64" = 1'-0"

 70. FormatScaleInImperial((7)
     7'-0" = 1'-0"

 71. FormatScaleInImperial((7.1)
     7'-1 13/64" = 1'-0"

 72. FormatScaleInImperial((7.2)
     7'-2 13/32" = 1'-0"

 73. FormatScaleInImperial((7.3)
     7'-3 19/32" = 1'-0"

 74. FormatScaleInImperial((7.4)
     7'-4 51/64" = 1'-0"

 75. FormatScaleInImperial((7.5)
     7'-6" = 1'-0"

 76. FormatScaleInImperial((7.6)
     7'-7 13/64" = 1'-0"

 77. FormatScaleInImperial((7.7)
     7'-8 13/32" = 1'-0"

 78. FormatScaleInImperial((7.8)
     7'-9 19/32" = 1'-0"

 79. FormatScaleInImperial((7.9)
     7'-10 51/64" = 1'-0"

 80. FormatScaleInImperial((8)
     8'-0" = 1'-0"

 81. FormatScaleInImperial((8.1)
     8'-1 13/64" = 1'-0"

 82. FormatScaleInImperial((8.2)
     8'-2 13/32" = 1'-0"

 83. FormatScaleInImperial((8.3)
     8'-3 19/32" = 1'-0"

 84. FormatScaleInImperial((8.4)
     8'-4 51/64" = 1'-0"

 85. FormatScaleInImperial((8.5)
     8'-6" = 1'-0"

 86. FormatScaleInImperial((8.6)
     8'-7 13/64" = 1'-0"

 87. FormatScaleInImperial((8.7)
     8'-8 13/32" = 1'-0"

 88. FormatScaleInImperial((8.8)
     8'-9 19/32" = 1'-0"

 89. FormatScaleInImperial((8.9)
     8'-10 51/64" = 1'-0"

 90. FormatScaleInImperial((9)
     9'-0" = 1'-0"

 91. FormatScaleInImperial((9.1)
     9'-1 13/64" = 1'-0"

 92. FormatScaleInImperial((9.2)
     9'-2 13/32" = 1'-0"

 93. FormatScaleInImperial((9.3)
     9'-3 19/32" = 1'-0"

 94. FormatScaleInImperial((9.4)
     9'-4 51/64" = 1'-0"

 95. FormatScaleInImperial((9.5)
     9'-6" = 1'-0"

 96. FormatScaleInImperial((9.6)
     9'-7 13/64" = 1'-0"

 97. FormatScaleInImperial((9.7)
     9'-8 13/32" = 1'-0"

 98. FormatScaleInImperial((9.8)
     9'-9 19/32" = 1'-0"

 99. FormatScaleInImperial((9.9)
     9'-10 51/64" = 1'-0"

100. FormatScaleInImperial((10)
     10'-0" = 1'-0"

101. FormatScaleInImperial((10.1)
     10'-1 13/64" = 1'-0"

102. FormatScaleInImperial((10.2)
     10'-2 13/32" = 1'-0"

103. FormatScaleInImperial((10.3)
     10'-3 19/32" = 1'-0"

104. FormatScaleInImperial((10.4)
     10'-4 51/64" = 1'-0"

105. FormatScaleInImperial((10.5)
     10'-6" = 1'-0"

106. FormatScaleInImperial((10.6)
     10'-7 13/64" = 1'-0"

107. FormatScaleInImperial((10.7)
     10'-8 13/32" = 1'-0"

108. FormatScaleInImperial((10.8)
     10'-9 19/32" = 1'-0"

109. FormatScaleInImperial((10.9)
     10'-10 51/64" = 1'-0"

110. FormatScaleInImperial((11)
     11'-0" = 1'-0"

111. FormatScaleInImperial((11.1)
     11'-1 13/64" = 1'-0"

112. FormatScaleInImperial((11.2)
     11'-2 13/32" = 1'-0"

113. FormatScaleInImperial((11.3)
     11'-3 19/32" = 1'-0"

114. FormatScaleInImperial((11.4)
     11'-4 51/64" = 1'-0"

115. FormatScaleInImperial((11.5)
     11'-6" = 1'-0"

116. FormatScaleInImperial((11.6)
     11'-7 13/64" = 1'-0"

117. FormatScaleInImperial((11.7)
     11'-8 13/32" = 1'-0"

118. FormatScaleInImperial((11.8)
     11'-9 19/32" = 1'-0"

119. FormatScaleInImperial((11.9)
     11'-10 51/64" = 1'-0"

120. FormatScaleInImperial((12)
     12'-0" = 1'-0"

121. FormatScaleInImperial((12.1)
     12'-1 13/64" = 1'-0"

122. FormatScaleInImperial((12.2)
     12'-2 13/32" = 1'-0"

123. FormatScaleInImperial((12.3)
     12'-3 19/32" = 1'-0"

124. FormatScaleInImperial((12.4)
     12'-4 51/64" = 1'-0"

125. FormatScaleInImperial((12.5)
     12'-6" = 1'-0"

126. FormatScaleInImperial((12.6)
     12'-7 13/64" = 1'-0"

127. FormatScaleInImperial((12.7)
     12'-8 13/32" = 1'-0"

128. FormatScaleInImperial((12.8)
     12'-9 19/32" = 1'-0"

129. FormatScaleInImperial((12.9)
     12'-10 51/64" = 1'-0"

130. FormatScaleInImperial((13)
     13'-0" = 1'-0"

131. FormatScaleInImperial((13.1)
     13'-1 13/64" = 1'-0"

132. FormatScaleInImperial((13.2)
     13'-2 13/32" = 1'-0"

133. FormatScaleInImperial((13.3)
     13'-3 19/32" = 1'-0"

134. FormatScaleInImperial((13.4)
     13'-4 51/64" = 1'-0"

135. FormatScaleInImperial((13.5)
     13'-6" = 1'-0"

136. FormatScaleInImperial((13.6)
     13'-7 13/64" = 1'-0"

137. FormatScaleInImperial((13.7)
     13'-8 13/32" = 1'-0"

138. FormatScaleInImperial((13.8)
     13'-9 19/32" = 1'-0"

139. FormatScaleInImperial((13.9)
     13'-10 51/64" = 1'-0"

140. FormatScaleInImperial((14)
     14'-0" = 1'-0"

141. FormatScaleInImperial((14.1)
     14'-1 13/64" = 1'-0"

142. FormatScaleInImperial((14.2)
     14'-2 13/32" = 1'-0"

143. FormatScaleInImperial((14.3)
     14'-3 19/32" = 1'-0"

144. FormatScaleInImperial((14.4)
     14'-4 51/64" = 1'-0"

145. FormatScaleInImperial((14.5)
     14'-6" = 1'-0"

146. FormatScaleInImperial((14.6)
     14'-7 13/64" = 1'-0"

147. FormatScaleInImperial((14.7)
     14'-8 13/32" = 1'-0"

148. FormatScaleInImperial((14.8)
     14'-9 19/32" = 1'-0"

149. FormatScaleInImperial((14.9)
     14'-10 51/64" = 1'-0"

150. FormatScaleInImperial((15)
     15'-0" = 1'-0"

DECIMAL DECIMAL SCALE TO IMPERIAL REPRESENTATION:
Subdivisions: 128

  1. FormatScaleInImperial((0.1)
     1 13/64" = 1'-0"

  2. FormatScaleInImperial((0.2)
     2 51/128" = 1'-0"

  3. FormatScaleInImperial((0.3)
     3 77/128" = 1'-0"

  4. FormatScaleInImperial((0.4)
     4 51/64" = 1'-0"

  5. FormatScaleInImperial((0.5)
     6" = 1'-0"

  6. FormatScaleInImperial((0.6)
     7 13/64" = 1'-0"

  7. FormatScaleInImperial((0.7)
     8 51/128" = 1'-0"

  8. FormatScaleInImperial((0.8)
     9 77/128" = 1'-0"

  9. FormatScaleInImperial((0.9)
     10 51/64" = 1'-0"

 10. FormatScaleInImperial((1)
     1'-0" = 1'-0"

 11. FormatScaleInImperial((1.1)
     1'-1 13/64" = 1'-0"

 12. FormatScaleInImperial((1.2)
     1'-2 51/128" = 1'-0"

 13. FormatScaleInImperial((1.3)
     1'-3 77/128" = 1'-0"

 14. FormatScaleInImperial((1.4)
     1'-4 51/64" = 1'-0"

 15. FormatScaleInImperial((1.5)
     1'-6" = 1'-0"

 16. FormatScaleInImperial((1.6)
     1'-7 13/64" = 1'-0"

 17. FormatScaleInImperial((1.7)
     1'-8 51/128" = 1'-0"

 18. FormatScaleInImperial((1.8)
     1'-9 77/128" = 1'-0"

 19. FormatScaleInImperial((1.9)
     1'-10 51/64" = 1'-0"

 20. FormatScaleInImperial((2)
     2'-0" = 1'-0"

 21. FormatScaleInImperial((2.1)
     2'-1 13/64" = 1'-0"

 22. FormatScaleInImperial((2.2)
     2'-2 51/128" = 1'-0"

 23. FormatScaleInImperial((2.3)
     2'-3 77/128" = 1'-0"

 24. FormatScaleInImperial((2.4)
     2'-4 51/64" = 1'-0"

 25. FormatScaleInImperial((2.5)
     2'-6" = 1'-0"

 26. FormatScaleInImperial((2.6)
     2'-7 13/64" = 1'-0"

 27. FormatScaleInImperial((2.7)
     2'-8 51/128" = 1'-0"

 28. FormatScaleInImperial((2.8)
     2'-9 77/128" = 1'-0"

 29. FormatScaleInImperial((2.9)
     2'-10 51/64" = 1'-0"

 30. FormatScaleInImperial((3)
     3'-0" = 1'-0"

 31. FormatScaleInImperial((3.1)
     3'-1 13/64" = 1'-0"

 32. FormatScaleInImperial((3.2)
     3'-2 51/128" = 1'-0"

 33. FormatScaleInImperial((3.3)
     3'-3 77/128" = 1'-0"

 34. FormatScaleInImperial((3.4)
     3'-4 51/64" = 1'-0"

 35. FormatScaleInImperial((3.5)
     3'-6" = 1'-0"

 36. FormatScaleInImperial((3.6)
     3'-7 13/64" = 1'-0"

 37. FormatScaleInImperial((3.7)
     3'-8 51/128" = 1'-0"

 38. FormatScaleInImperial((3.8)
     3'-9 77/128" = 1'-0"

 39. FormatScaleInImperial((3.9)
     3'-10 51/64" = 1'-0"

 40. FormatScaleInImperial((4)
     4'-0" = 1'-0"

 41. FormatScaleInImperial((4.1)
     4'-1 13/64" = 1'-0"

 42. FormatScaleInImperial((4.2)
     4'-2 51/128" = 1'-0"

 43. FormatScaleInImperial((4.3)
     4'-3 77/128" = 1'-0"

 44. FormatScaleInImperial((4.4)
     4'-4 51/64" = 1'-0"

 45. FormatScaleInImperial((4.5)
     4'-6" = 1'-0"

 46. FormatScaleInImperial((4.6)
     4'-7 13/64" = 1'-0"

 47. FormatScaleInImperial((4.7)
     4'-8 51/128" = 1'-0"

 48. FormatScaleInImperial((4.8)
     4'-9 77/128" = 1'-0"

 49. FormatScaleInImperial((4.9)
     4'-10 51/64" = 1'-0"

 50. FormatScaleInImperial((5)
     5'-0" = 1'-0"

 51. FormatScaleInImperial((5.1)
     5'-1 13/64" = 1'-0"

 52. FormatScaleInImperial((5.2)
     5'-2 51/128" = 1'-0"

 53. FormatScaleInImperial((5.3)
     5'-3 77/128" = 1'-0"

 54. FormatScaleInImperial((5.4)
     5'-4 51/64" = 1'-0"

 55. FormatScaleInImperial((5.5)
     5'-6" = 1'-0"

 56. FormatScaleInImperial((5.6)
     5'-7 13/64" = 1'-0"

 57. FormatScaleInImperial((5.7)
     5'-8 51/128" = 1'-0"

 58. FormatScaleInImperial((5.8)
     5'-9 77/128" = 1'-0"

 59. FormatScaleInImperial((5.9)
     5'-10 51/64" = 1'-0"

 60. FormatScaleInImperial((6)
     6'-0" = 1'-0"

 61. FormatScaleInImperial((6.1)
     6'-1 13/64" = 1'-0"

 62. FormatScaleInImperial((6.2)
     6'-2 51/128" = 1'-0"

 63. FormatScaleInImperial((6.3)
     6'-3 77/128" = 1'-0"

 64. FormatScaleInImperial((6.4)
     6'-4 51/64" = 1'-0"

 65. FormatScaleInImperial((6.5)
     6'-6" = 1'-0"

 66. FormatScaleInImperial((6.6)
     6'-7 13/64" = 1'-0"

 67. FormatScaleInImperial((6.7)
     6'-8 51/128" = 1'-0"

 68. FormatScaleInImperial((6.8)
     6'-9 77/128" = 1'-0"

 69. FormatScaleInImperial((6.9)
     6'-10 51/64" = 1'-0"

 70. FormatScaleInImperial((7)
     7'-0" = 1'-0"

 71. FormatScaleInImperial((7.1)
     7'-1 13/64" = 1'-0"

 72. FormatScaleInImperial((7.2)
     7'-2 51/128" = 1'-0"

 73. FormatScaleInImperial((7.3)
     7'-3 77/128" = 1'-0"

 74. FormatScaleInImperial((7.4)
     7'-4 51/64" = 1'-0"

 75. FormatScaleInImperial((7.5)
     7'-6" = 1'-0"

 76. FormatScaleInImperial((7.6)
     7'-7 13/64" = 1'-0"

 77. FormatScaleInImperial((7.7)
     7'-8 51/128" = 1'-0"

 78. FormatScaleInImperial((7.8)
     7'-9 77/128" = 1'-0"

 79. FormatScaleInImperial((7.9)
     7'-10 51/64" = 1'-0"

 80. FormatScaleInImperial((8)
     8'-0" = 1'-0"

 81. FormatScaleInImperial((8.1)
     8'-1 13/64" = 1'-0"

 82. FormatScaleInImperial((8.2)
     8'-2 51/128" = 1'-0"

 83. FormatScaleInImperial((8.3)
     8'-3 77/128" = 1'-0"

 84. FormatScaleInImperial((8.4)
     8'-4 51/64" = 1'-0"

 85. FormatScaleInImperial((8.5)
     8'-6" = 1'-0"

 86. FormatScaleInImperial((8.6)
     8'-7 13/64" = 1'-0"

 87. FormatScaleInImperial((8.7)
     8'-8 51/128" = 1'-0"

 88. FormatScaleInImperial((8.8)
     8'-9 77/128" = 1'-0"

 89. FormatScaleInImperial((8.9)
     8'-10 51/64" = 1'-0"

 90. FormatScaleInImperial((9)
     9'-0" = 1'-0"

 91. FormatScaleInImperial((9.1)
     9'-1 13/64" = 1'-0"

 92. FormatScaleInImperial((9.2)
     9'-2 51/128" = 1'-0"

 93. FormatScaleInImperial((9.3)
     9'-3 77/128" = 1'-0"

 94. FormatScaleInImperial((9.4)
     9'-4 51/64" = 1'-0"

 95. FormatScaleInImperial((9.5)
     9'-6" = 1'-0"

 96. FormatScaleInImperial((9.6)
     9'-7 13/64" = 1'-0"

 97. FormatScaleInImperial((9.7)
     9'-8 51/128" = 1'-0"

 98. FormatScaleInImperial((9.8)
     9'-9 77/128" = 1'-0"

 99. FormatScaleInImperial((9.9)
     9'-10 51/64" = 1'-0"

100. FormatScaleInImperial((10)
     10'-0" = 1'-0"

101. FormatScaleInImperial((10.1)
     10'-1 13/64" = 1'-0"

102. FormatScaleInImperial((10.2)
     10'-2 51/128" = 1'-0"

103. FormatScaleInImperial((10.3)
     10'-3 77/128" = 1'-0"

104. FormatScaleInImperial((10.4)
     10'-4 51/64" = 1'-0"

105. FormatScaleInImperial((10.5)
     10'-6" = 1'-0"

106. FormatScaleInImperial((10.6)
     10'-7 13/64" = 1'-0"

107. FormatScaleInImperial((10.7)
     10'-8 51/128" = 1'-0"

108. FormatScaleInImperial((10.8)
     10'-9 77/128" = 1'-0"

109. FormatScaleInImperial((10.9)
     10'-10 51/64" = 1'-0"

110. FormatScaleInImperial((11)
     11'-0" = 1'-0"

111. FormatScaleInImperial((11.1)
     11'-1 13/64" = 1'-0"

112. FormatScaleInImperial((11.2)
     11'-2 51/128" = 1'-0"

113. FormatScaleInImperial((11.3)
     11'-3 77/128" = 1'-0"

114. FormatScaleInImperial((11.4)
     11'-4 51/64" = 1'-0"

115. FormatScaleInImperial((11.5)
     11'-6" = 1'-0"

116. FormatScaleInImperial((11.6)
     11'-7 13/64" = 1'-0"

117. FormatScaleInImperial((11.7)
     11'-8 51/128" = 1'-0"

118. FormatScaleInImperial((11.8)
     11'-9 77/128" = 1'-0"

119. FormatScaleInImperial((11.9)
     11'-10 51/64" = 1'-0"

120. FormatScaleInImperial((12)
     12'-0" = 1'-0"

121. FormatScaleInImperial((12.1)
     12'-1 13/64" = 1'-0"

122. FormatScaleInImperial((12.2)
     12'-2 51/128" = 1'-0"

123. FormatScaleInImperial((12.3)
     12'-3 77/128" = 1'-0"

124. FormatScaleInImperial((12.4)
     12'-4 51/64" = 1'-0"

125. FormatScaleInImperial((12.5)
     12'-6" = 1'-0"

126. FormatScaleInImperial((12.6)
     12'-7 13/64" = 1'-0"

127. FormatScaleInImperial((12.7)
     12'-8 51/128" = 1'-0"

128. FormatScaleInImperial((12.8)
     12'-9 77/128" = 1'-0"

129. FormatScaleInImperial((12.9)
     12'-10 51/64" = 1'-0"

130. FormatScaleInImperial((13)
     13'-0" = 1'-0"

131. FormatScaleInImperial((13.1)
     13'-1 13/64" = 1'-0"

132. FormatScaleInImperial((13.2)
     13'-2 51/128" = 1'-0"

133. FormatScaleInImperial((13.3)
     13'-3 77/128" = 1'-0"

134. FormatScaleInImperial((13.4)
     13'-4 51/64" = 1'-0"

135. FormatScaleInImperial((13.5)
     13'-6" = 1'-0"

136. FormatScaleInImperial((13.6)
     13'-7 13/64" = 1'-0"

137. FormatScaleInImperial((13.7)
     13'-8 51/128" = 1'-0"

138. FormatScaleInImperial((13.8)
     13'-9 77/128" = 1'-0"

139. FormatScaleInImperial((13.9)
     13'-10 51/64" = 1'-0"

140. FormatScaleInImperial((14)
     14'-0" = 1'-0"

141. FormatScaleInImperial((14.1)
     14'-1 13/64" = 1'-0"

142. FormatScaleInImperial((14.2)
     14'-2 51/128" = 1'-0"

143. FormatScaleInImperial((14.3)
     14'-3 77/128" = 1'-0"

144. FormatScaleInImperial((14.4)
     14'-4 51/64" = 1'-0"

145. FormatScaleInImperial((14.5)
     14'-6" = 1'-0"

146. FormatScaleInImperial((14.6)
     14'-7 13/64" = 1'-0"

147. FormatScaleInImperial((14.7)
     14'-8 51/128" = 1'-0"

148. FormatScaleInImperial((14.8)
     14'-9 77/128" = 1'-0"

149. FormatScaleInImperial((14.9)
     14'-10 51/64" = 1'-0"

150. FormatScaleInImperial((15)
     15'-0" = 1'-0"
