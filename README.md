# KatalonShopUITest1

The framework was built using Specflow, Selenium on the .Net Framework. 
The framework is a Behavioural diven Development framwork using the Page Object Model. It had the following folders ( Feature, Pages, StepDefinition, Hooks and Utilities)
A separate folder was created called Utilities which had the helpers class and the Config file which can host variables related to various functionalities under test.
It has a helpers class with an explicit wait and a method to handle ElementClickInterceptedException, which were built to be used over and over again within the framework as need arises. 
It has a separate step to launch the application under test. This step was added in the common step folder, so that this step can be used by subsequent tests.

With reporting being a fundamental part of testing, the Specflow living Doc was integrated, which presents the test results in a format which can be clearly understood by all stakeholders of the project. 
The Specflow Living Doc can be integrated into our Build Pipeline, so that the entire scrum team can update them selves with test results when needed, after the build pipeline runs.
However, since CI/CD is out of scope for this exercise, below is a snippet of what the report would look like in Azure DevOps Ovwerview after every CI pipeline runs as seen below.
![image](https://user-images.githubusercontent.com/61115566/236934748-a796ea15-d39b-44ef-b803-416603dac50a.png)
![image](https://user-images.githubusercontent.com/61115566/236934856-f5804b03-0f3d-4a45-8095-48f1d9f480b3.png)

Please find below the screenshot for the passed test in visual Studio test explorer.
![image](https://user-images.githubusercontent.com/61115566/236927060-a2fd6f1f-6d21-4213-8fe1-68fc8ca4b5de.png)




