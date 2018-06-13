using System.Collections.Generic;
using System.Linq;
using ESFA.DC.OPA.Model.Interface;
using FluentAssertions;
using Xunit;

namespace ESFA.DC.OPA.Model.Tests
{
    public class DataEntityTests
    {
        #region Data Entity Tests

        /// <summary>
        /// Return DataEntity Item
        /// /// </summary>
        [Fact(DisplayName = "DataEntity - Does Exist"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_DoesExist()
        {
            //ARRANGE
            // Use Test Helpers

            //ACT
            DataEntity dataEntityExists = new DataEntity(entityNameDefault);

            //ASSERT
            dataEntityExists.Should().NotBeNull();
        }

        /// <summary>
        /// Return DataEntity Item and check value
        /// /// </summary>
        [Fact(DisplayName = "DataEntity - Does Match"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_DoesMatch()
        {
            //ARRANGE
            // Use Test Helpers

            //ACT
            DataEntity dataEntityMatch = new DataEntity(entityNameDefault);

            //ASSERT
            dataEntityMatch.Should().BeEquivalentTo(entityDefault);
        }

        /// <summary>
        /// Return DataEntity Item and check value
        /// /// </summary>
        [Fact(DisplayName = "DataEntity - Does Not Match"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_DoesNotMatch()
        {
            //ARRANGE
            string dataEntityNotMatchEntityVal = "Entity";

            //ACT
            DataEntity dataEntityNotMatch = new DataEntity(dataEntityNotMatchEntityVal);

            //ASSERT
            dataEntityNotMatch.Should().NotBeSameAs(entityDefault);
        }

        #endregion

        #region Data Entity Name Tests

        /// <summary>
        /// Return DataEntity EntityName and check values
        /// /// </summary>
        [Fact(DisplayName = "DataEntity - EntityName Does Exist"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_EntityName_DoesExist()
        {
            //ARRANGE
            // Use Test Helpers

            //ACT
            DataEntity entityNameExists = new DataEntity(entityNameDefault);

            //ASSERT
            entityNameExists.EntityName.Should().NotBeNull();
        }

        /// <summary>
        /// Return DataEntity EntityName and check values
        /// /// </summary>
        [Fact(DisplayName = "DataEntity - EntityName Does Match"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_EntityName_DoesMatch()
        {
            //ARRANGE
            // Use Test Helpers

            //ACT
            DataEntity entityNameMatch = new DataEntity(entityNameDefault);

            //ASSERT
            entityNameMatch.EntityName.Should().BeEquivalentTo(entityNameDefault);
        }

        /// <summary>
        /// Return DataEntity EntityName and check values
        /// /// </summary>
        [Fact(DisplayName = "DataEntity - EntityName Does Not Match"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_EntityName_DoesNotMatch()
        {
            //ARRANGE
            string dataEntityNotMatchEntityVal = "Entity";

            //ACT
            DataEntity entityNameNotMatch = new DataEntity(dataEntityNotMatchEntityVal);

            //ASSERT
            entityNameNotMatch.EntityName.Should().NotBeSameAs(entityNameDefault);
        }

        /// <summary>
        /// Return DataEntity EntityName and check values
        /// </summary>
        [Fact(DisplayName = "DataEntity - EntityName Children Does Match"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_EntityName_Children_DoesMatch()
        {
            //ARRANGE
            DataEntity entityChildNameMatch = new DataEntity(entityNameDefault);

            //ACT
            entityChildNameMatch.AddChild(entityChildDefault);


            //ASSERT
            entityChildNameMatch.Children.Select(c => c.EntityName).First().Should().BeEquivalentTo(entityChildNameDefault);
        }

        #endregion

        #region Data Entity Attributes Tests

        /// <summary>
        /// Return DataEntity Attributes and check value
        /// /// </summary>
        [Fact(DisplayName = "DataEntity - Atrributes Does Exist Empty"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_Attributes_DoesExistEmpty()
        {
            //ARRANGE
            //Use Test Helpers

            //ACT
            DataEntity attributesExistEmpty = new DataEntity(entityNameDefault);

            //ASSERT
            attributesExistEmpty.Attributes.Should().BeEmpty();
        }

        /// <summary>
        /// Return DataEntity Attributes and check value
        /// /// </summary>
        [Fact(DisplayName = "DataEntity - Atrributes Does Exist Not Empty"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_Attributes_DoesExistNotEmpty()
        {
            //ARRANGE
            DataEntity attributesExistNotEmpty = new DataEntity(entityNameDefault);

            //ACT
            attributesExistNotEmpty.Attributes.Add(attributeDataDefaultName, attributeDataDefault);

            //ASSERT
            attributesExistNotEmpty.Attributes.Should().NotBeEmpty();
        }

        /// <summary>
        /// Return DataEntity Attributes and check value
        /// /// </summary>
        [Fact(DisplayName = "DataEntity - Atrributes Count = zero"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_Attributes_CountZero()
        {
            //ARRANGE
            //Use Test Helpers

            //ACT
            DataEntity attributesCountZero = new DataEntity(entityNameDefault);

            //ASSERT
            attributesCountZero.Attributes.Count.Should().Be(0);
        }

        /// <summary>
        /// Return DataEntity Attributes and check value
        /// /// </summary>
        [Fact(DisplayName = "DataEntity - Atrributes Count = one"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_Attributes_CountOne()
        {
            //ARRANGE
            DataEntity attributesCountOne = new DataEntity(entityNameDefault);

            //ACT  
            attributesCountOne.Attributes.Add(attributeDataDefaultName, attributeDataDefault);

            //ASSERT
            attributesCountOne.Attributes.Count.Should().Be(1);
        }

        /// <summary>
        /// Return DataEntity Attributes and check value
        /// /// </summary>
        [Fact(DisplayName = "DataEntity - Atrributes Does Match"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_Attributes_DoesMatch()
        {
            //ARRANGE
            DataEntity attributesMatch = new DataEntity(entityNameDefault);

            //ACT
            attributesMatch.Attributes.Add(attributeDataDefaultName, attributeDataDefault);

            //ASSERT
            attributesMatch.Attributes.Should().BeEquivalentTo(attributesDefaultDictionary);
        }

        /// <summary>
        /// Return DataEntity Attributes and check value
        /// /// </summary>
        [Fact(DisplayName = "DataEntity - Atrributes Does Not Match"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_Attributes_DoesNotMatch()
        {
            //ARRANGE
            DataEntity attributesNotMatch = new DataEntity(entityNameDefault);

            //ACT
            attributesNotMatch.Attributes.Add("Attribute100", new AttributeData("Attribute100", 100));

            //ASSERT
            attributesNotMatch.Attributes.Should().NotBeSameAs(attributesDefaultDictionary);
        }

        #endregion

        #region Data Entity Parent Tests

        /// <summary>
        /// Return DataEntity Parent and check value
        /// /// </summary>
        [Fact(DisplayName = "DataEntity - Parent Does Exist"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_Parent_DoesExist()
        {
            //ARRANGE
            IDataEntity parentExists = new DataEntity(entityNameDefault);
            parentExists.AddChild(entityChildDefault);

            //ACT
            entityChildDefault.Parent = new DataEntity("Parent");

            //ASSERT
            parentExists.Children.First().Parent.Should().NotBeNull();
        }

        /// <summary>
        /// Return DataEntity Parent and check value
        /// /// </summary>
        [Fact(DisplayName = "DataEntity - Parent Does Not Exist"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_Parent_DoesNotExist()
        {
            DataEntity parentNotExists = new DataEntity(entityNameDefault);
            parentNotExists.AddChild(entityChildDefault);

            //ACT
            
            //ASSERT
            parentNotExists.Children.First().Parent.Should().BeNull();
        }

        /// <summary>
        /// Return DataEntity Parent and check value
        /// /// </summary>
        [Fact(DisplayName = "DataEntity - Parent Does Match"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_Parent_DoesMatch()
        {
            DataEntity parentMatch = new DataEntity(entityNameDefault);
            parentMatch.AddChild(entityChildDefault);

            //ACT
            entityChildDefault.Parent = new DataEntity("global");

            //ASSERT
            parentMatch.Children.First().Parent.Should().BeEquivalentTo(entityDefault);
        }

        /// <summary>
        /// Return DataEntity Parent and check value
        /// /// </summary>
        [Fact(DisplayName = "DataEntity - Parent Entity Name Correct"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_Parent_EntityNameCorrect()
        {
            DataEntity parentEntityName = new DataEntity(entityParentNameDefault);
            parentEntityName.AddChild(entityChildDefault);

            //ACT
            entityChildDefault.Parent = entityParentDefault;

            //ASSERT
            entityChildDefault.Parent.EntityName.Should().BeEquivalentTo(entityParentNameDefault);
        }

        /// <summary>
        /// Return DataEntity Parent and check value
        /// /// </summary>
        [Fact(DisplayName = "DataEntity - Parent Does Not Match"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_Parent_DoesNotMatch()
        {
            //ARRANGE
            DataEntity parentNotMatch = new DataEntity(entityNameDefault);
            parentNotMatch.AddChild(entityChildDefault);

            //ACT
            entityChildDefault.Parent = new DataEntity("NotParent");
            
            //ASSERT
            parentNotMatch.Children.First().Parent.Should().NotBeSameAs(entityParentDefault);
        }

        #endregion

        #region Data Entity Children Tests

        /// <summary>
        /// Return DataEntity Children
        /// </summary>
        [Fact(DisplayName = "DataEntity - Children Does Exist"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_Children_DoesExist()
        {
            //ARRANGE
            DataEntity childrenExists = new DataEntity(entityNameDefault);

            //ACT
            childrenExists.AddChildren(new List<DataEntity>()
            {
                new DataEntity("Child")
            });

            //ASSERT
            childrenExists.Children.Should().NotBeNullOrEmpty();
        }

        /// <summary>
        /// Return DataEntity Children and check values
        /// </summary>
        [Fact(DisplayName = "DataEntity - Children Does Not Exist"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_Children_DoesNotExist()
        {
            //ARRANGE 
            //UseTest Helpers

            //ACT
            DataEntity childrenNotExists = new DataEntity(entityNameDefault);


            //ASSERT
            childrenNotExists.Children.Should().BeNullOrEmpty();
        }

        /// <summary>
        /// Return DataEntity Children and check values
        /// </summary>
        [Fact(DisplayName = "DataEntity - Children Does Match"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_Children_DoesMatch()
        {
            //ARRANGE
            DataEntity childrenMatch = new DataEntity(entityNameDefault);

            //ACT
            childrenMatch.AddChildren(new List<DataEntity>()
            {
                new DataEntity("Child")
            });

            //ASSERT
            childrenMatch.Children.Should().BeEquivalentTo(entityChildDefault);
        }

        /// <summary>
        /// Return DataEntity Children and check values
        /// </summary>
        [Fact(DisplayName = "DataEntity - Children Does Not Match"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_Children_DoesNotMatch()
        {
            //ARRANGE
            DataEntity childrenNotMatch = new DataEntity(entityNameDefault);

            //ACT
            childrenNotMatch.AddChildren(new List<DataEntity>()
            {
                new DataEntity("NotChild")
            });

            //ASSERT
            childrenNotMatch.Children.First().Should().NotBeSameAs(entityChildDefault);
        }

        /// <summary>
        /// Return DataEntity Children and check values
        /// </summary>
        [Fact(DisplayName = "DataEntity - Children Does Match (Many)"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_Children_DoesMatchMany()
        {
            //ARRANGE
            DataEntity childrenMatchList = new DataEntity(entityNameDefault);

            //ACT
            childrenMatchList.AddChildren(new List<DataEntity>()
            {
                new DataEntity("Child1"),
                new DataEntity("Child2")
            });

            //ASSERT
            childrenMatchList.Children.Should().BeEquivalentTo(childList);
        }

        #endregion

        #region Data Entity LearnRefNumber Tests

        /// <summary>
        /// Return DataEntity and check LearnRefNumber
        /// </summary>
        [Fact(DisplayName = "DataEntity - LearnRefNumber Does Exist"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_LearnRefNumber_DoesExist()
        {
            //ARRANGE
            DataEntity learnRefNumberAttributeExists = new DataEntity(entityLearnerNameDefault);
            learnRefNumberAttributeExists.Attributes.Add(attributeDataLearnerName, attributeDataLearnerDefault);

            //ACT
            var learnRefNumberExists = learnRefNumberAttributeExists.LearnRefNumber;

            //ASSERT
            learnRefNumberExists.Should().NotBeNullOrEmpty();
        }

        /// <summary>
        /// Return DataEntity and check LearnRefNumber
        /// </summary>
        [Fact(DisplayName = "DataEntity - LearnRefNumber Does Not Exist"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_LearnRefNumber_DoesNotExist()
        {
            //ARRANGE
            DataEntity learnRefNumberAttributeNotExists = new DataEntity(entityLearnerNameDefault);

            //ACT
            var learnRefNumberNotExists = learnRefNumberAttributeNotExists.LearnRefNumber;

            //ASSERT
            learnRefNumberNotExists.Should().BeNullOrEmpty();
        }


        /// <summary>
        /// Return DataEntity and check LearnRefNumber
        /// </summary>
        [Fact(DisplayName = "DataEntity - LearnRefNumber Does Match"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_LearnRefNumber_DoesMatch()
        {
            //ARRANGE
            DataEntity learnRefNumberAttributeMatch = new DataEntity(entityLearnerNameDefault);
            learnRefNumberAttributeMatch.Attributes.Add(attributeDataLearnerName, attributeDataLearnerDefault);

            //ACT
            var learnRefNumberMatch = learnRefNumberAttributeMatch.LearnRefNumber;

            //ASSERT
            learnRefNumberMatch.Should().BeEquivalentTo(attributeDataLearnerDefault.Value.ToString());
        }


        /// <summary>
        /// Return DataEntity and check LearnRefNumber
        /// </summary>
        [Fact(DisplayName = "DataEntity - LearnRefNumber Does Not Match"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_LearnRefNumber_DoesNotMatch()
        {
            //ARRANGE
            DataEntity learnRefNumberAttributeNotMatch = new DataEntity(entityLearnerNameDefault);
            learnRefNumberAttributeNotMatch.Attributes
                .Add(attributeDataLearnerName, new AttributeData("LearnRefNumber", "LearnerTest20"));

            //ACT
            var learnRefNumberNotMatch = learnRefNumberAttributeNotMatch.LearnRefNumber;

            //ASSERT
            learnRefNumberNotMatch.Should().NotBeSameAs(attributeDataLearnerDefault.Value.ToString());
        }

        #endregion

        #region Data Entity IsGlobal Tests

        /// <summary>
        /// Return DataEntity Item and check IsGlobal flag
        /// </summary>
        [Fact(DisplayName = "DataEntity - IsGLobal True"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_IsGLobal_True()
        {
            //ARRANGE
            DataEntity dataEntityIsGlobalTrue = new DataEntity(entityNameDefault);

            //ACT
            var isGlobalTrue = dataEntityIsGlobalTrue.IsGlobal;

            //ASSERT
            isGlobalTrue.Should().BeTrue();
        }

        /// <summary>
        /// Return DataEntity Item and check IsGlobal flag
        /// </summary>
        [Fact(DisplayName = "DataEntity - IsGLobal False"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_IsGLobal_False()
        {
            //ARRANGE
            DataEntity dataEntityIsGlobalFalseNameNotMatch = new DataEntity("NotGlobal");

            //ACT
            var isGlobalFalseNameNotMatch = dataEntityIsGlobalFalseNameNotMatch.IsGlobal;

            //ASSERT
            isGlobalFalseNameNotMatch.Should().BeFalse();
        }

        #endregion

        #region Data Entity AddChild Tests

        /// <summary>
        /// Return DataEntity Child and check value
        /// </summary>
        [Fact(DisplayName = "DataEntity - AddChild Does Exist"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_AddChild_DoesExist()
        {
            //ARRANGE
            var addChildExists = entityDefault;

            //ACT
            addChildExists.AddChild(new DataEntity("Learner"));

            //ASSERT
            addChildExists.Children.Should().NotBeNullOrEmpty();
        }

        /// <summary>
        /// Return DataEntity Child and check value
        /// </summary>
        [Fact(DisplayName = "DataEntity - AddChild Does Match"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_AddChild_DoesMatch()
        {
            //ARRANGE
            var addChildMatch = entityDefault;

            //ACT
            addChildMatch.AddChild(new DataEntity("Learner"));

            //ASSERT
            addChildMatch.Children.Should().BeEquivalentTo(entityLearnerDefault);
        }

        /// <summary>
        /// Return DataEntity Child and check value
        /// </summary>
        [Fact(DisplayName = "DataEntity - AddChild Does Not Match"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_AddChild_DoesNotMatch()
        {
            //ARRANGE
            var addChildNotMatch = entityDefault;

            //ACT
            addChildNotMatch.AddChild(new DataEntity("Learner"));

            //ASSERT
            addChildNotMatch.Children.First().Should().NotBeSameAs(entityLearnerDefault);
        }

        /// <summary>
        /// Return DataEntity Child and check value
        /// </summary>
        [Fact(DisplayName = "DataEntity - AddChild Count"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_AddChild_Count()
        {
            //ARRANGE
            var addChildCount = entityDefault;

            //ACT
            addChildCount.AddChild(new DataEntity("Learner"));

            //ASSERT
            addChildCount.Children.Count.Should().Be(1);
        }

        #endregion

        #region Data Entity AddChildren Tests

        /// <summary>
        /// Return DataEntity Children and check value
        /// </summary>
        [Fact(DisplayName = "DataEntity - AddChildren Does Exist"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_AddChildren_DoesExist()
        {
            //ARRANGE
            var addChildrenExists = entityDefault;

            //ACT
            addChildrenExists.AddChildren(childList);

            //ASSERT
            addChildrenExists.Children.Should().NotBeNullOrEmpty();
        }

        /// <summary>
        /// Return DataEntity Children and check value
        /// </summary>
        [Fact(DisplayName = "DataEntity - AddChildren Does Match"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_AddChildren_DoesMatch()
        {
            //ARRANGE
            var addChildrenMatch = entityDefault;

            //ACT
            addChildrenMatch.AddChildren(childList);

            //ASSERT
            addChildrenMatch.Children.Should().BeEquivalentTo(childList);
        }

        /// <summary>
        /// Return DataEntity Children and check values
        /// </summary>
        [Fact(DisplayName = "DataEntity - AddChildren Does Not Match"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_AddChildren_DoesNotMatch()
        {
            //ARRANGE
            var addChildrenNotMatch = entityDefault;
            var notMatchList = new List<DataEntity>()
            {
                new DataEntity("Child100"),
                new DataEntity("Child200")
            };

            //ACT
            addChildrenNotMatch.AddChildren(notMatchList);

            //ASSERT
            addChildrenNotMatch.Children.Should().NotBeSameAs(childList);
        }

        /// <summary>
        /// Return DataEntity Children and count values
        /// </summary>
        [Fact(DisplayName = "DataEntity - AddChildren Count"), Trait("OPA Model", "Unit")]
        public void OPA_DataEntity_AddChildren_Count()
        {
            //ARRANGE
            var addChildrenCount = entityDefault;

            //ACT
            addChildrenCount.AddChildren(childList);

            //ASSERT
            addChildrenCount.Children.Count.Should().Be(2);
        }

        #endregion

        #region Test Helpers

        //Entity
        private readonly string entityNameDefault = "global";
        private readonly DataEntity entityDefault = new DataEntity("global");

        private readonly string entityParentNameDefault = "Parent";
        private readonly DataEntity entityParentDefault = new DataEntity("Parent");

        private readonly string entityChildNameDefault = "Child";
        private readonly DataEntity entityChildDefault = new DataEntity("Child");
        private readonly IList<DataEntity> childList =
            new List<DataEntity>()
            {
                new DataEntity("Child1"),
                new DataEntity("Child2")
            };

        private readonly string entityLearnerNameDefault = "Learner";
        private readonly DataEntity entityLearnerDefault = new DataEntity("Learner");


        //Attributes
        private readonly IDictionary<string, IAttributeData> attributesDefaultDictionary
            = new Dictionary<string, IAttributeData>()
            {
                { "Attribute1", new AttributeData("Attribute1", 10) }
            };
        private readonly string attributeDataDefaultName = "Attribute1";
        private readonly AttributeData attributeDataDefault = new AttributeData("Attribute1", 10);
        private readonly string attributeDataLearnerName = "LearnRefNumber";
        private readonly AttributeData attributeDataLearnerDefault = new AttributeData("LearnRefNumber", "LearnerTest1");


        #endregion

    }
}

