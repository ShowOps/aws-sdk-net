/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the PutItem operation.
    /// Creates a new item, or replaces an old item with a new item. If an item that has the
    /// same primary key as the new item already exists in the specified table, the new item
    /// completely replaces the existing item. You can perform a conditional put operation
    /// (add a new item if one with the specified primary key doesn't exist), or replace an
    /// existing item if it has certain attribute values. 
    /// 
    ///  
    /// <para>
    /// In addition to putting an item, you can also return the item's attribute values in
    /// the same operation, using the <i>ReturnValues</i> parameter.
    /// </para>
    ///  
    /// <para>
    /// When you add an item, the primary key attribute(s) are the only required attributes.
    /// Attribute values cannot be null. String and Binary type attributes must have lengths
    /// greater than zero. Set type attributes cannot be empty. Requests with empty values
    /// will be rejected with a <i>ValidationException</i> exception.
    /// </para>
    ///  
    /// <para>
    /// You can request that <i>PutItem</i> return either a copy of the original item (before
    /// the update) or a copy of the updated item (after the update). For more information,
    /// see the <i>ReturnValues</i> description below.
    /// </para>
    ///  <note> 
    /// <para>
    /// To prevent a new item from replacing an existing item, use a conditional put operation
    /// with <i>ComparisonOperator</i> set to <code>NULL</code> for the primary key attribute,
    /// or attributes.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information about using this API, see <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithItems.html">Working
    /// with Items</a> in the <i>Amazon DynamoDB Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class PutItemRequest : AmazonDynamoDBRequest
    {
        private ConditionalOperator _conditionalOperator;
        private string _conditionExpression;
        private Dictionary<string, ExpectedAttributeValue> _expected = new Dictionary<string, ExpectedAttributeValue>();
        private Dictionary<string, string> _expressionAttributeNames = new Dictionary<string, string>();
        private Dictionary<string, AttributeValue> _expressionAttributeValues = new Dictionary<string, AttributeValue>();
        private Dictionary<string, AttributeValue> _item = new Dictionary<string, AttributeValue>();
        private ReturnConsumedCapacity _returnConsumedCapacity;
        private ReturnItemCollectionMetrics _returnItemCollectionMetrics;
        private ReturnValue _returnValues;
        private string _tableName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public PutItemRequest() { }

        /// <summary>
        /// Instantiates PutItemRequest with the parameterized properties
        /// </summary>
        /// <param name="tableName">The name of the table to contain the item.</param>
        /// <param name="item">A map of attribute name/value pairs, one for each attribute. Only the primary key attributes are required; you can optionally provide other attribute name-value pairs for the item. You must provide all of the attributes for the primary key. For example, with a hash type primary key, you only need to specify the hash attribute. For a hash-and-range type primary key, you must specify both the hash attribute and the range attribute. If you specify any attributes that are part of an index key, then the data types for those attributes must match those of the schema in the table's attribute definition. For more information about primary keys, see <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/DataModel.html#DataModelPrimaryKey">Primary Key</a> in the <i>Amazon DynamoDB Developer Guide</i>. Each element in the <i>Item</i> map is an <i>AttributeValue</i> object.</param>
        public PutItemRequest(string tableName, Dictionary<string, AttributeValue> item)
        {
            _tableName = tableName;
            _item = item;
        }

        /// <summary>
        /// Instantiates PutItemRequest with the parameterized properties
        /// </summary>
        /// <param name="tableName">The name of the table to contain the item.</param>
        /// <param name="item">A map of attribute name/value pairs, one for each attribute. Only the primary key attributes are required; you can optionally provide other attribute name-value pairs for the item. You must provide all of the attributes for the primary key. For example, with a hash type primary key, you only need to specify the hash attribute. For a hash-and-range type primary key, you must specify both the hash attribute and the range attribute. If you specify any attributes that are part of an index key, then the data types for those attributes must match those of the schema in the table's attribute definition. For more information about primary keys, see <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/DataModel.html#DataModelPrimaryKey">Primary Key</a> in the <i>Amazon DynamoDB Developer Guide</i>. Each element in the <i>Item</i> map is an <i>AttributeValue</i> object.</param>
        /// <param name="returnValues">Use <i>ReturnValues</i> if you want to get the item attributes as they appeared before they were updated with the <i>PutItem</i> request. For <i>PutItem</i>, the valid values are: <ul> <li> <code>NONE</code> - If <i>ReturnValues</i> is not specified, or if its value is <code>NONE</code>, then nothing is returned. (This setting is the default for <i>ReturnValues</i>.) </li> <li> <code>ALL_OLD</code> - If <i>PutItem</i> overwrote an attribute name-value pair, then the content of the old item is returned. </li> </ul></param>
        public PutItemRequest(string tableName, Dictionary<string, AttributeValue> item, ReturnValue returnValues)
        {
            _tableName = tableName;
            _item = item;
            _returnValues = returnValues;
        }

        /// <summary>
        /// Gets and sets the property ConditionalOperator. <important> 
        /// <para>
        /// There is a newer parameter available. Use <i>ConditionExpression</i> instead. Note
        /// that if you use <i>ConditionalOperator</i> and <i> ConditionExpression </i> at the
        /// same time, DynamoDB will return a <i>ValidationException</i> exception.
        /// </para>
        ///  
        /// <para>
        /// This parameter does not support lists or maps.
        /// </para>
        ///  </important> 
        /// <para>
        /// A logical operator to apply to the conditions in the <i>Expected</i> map:
        /// </para>
        ///  <ul> <li>
        /// <para>
        /// <code>AND</code> - If all of the conditions evaluate to true, then the entire map
        /// evaluates to true.
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>OR</code> - If at least one of the conditions evaluate to true, then the entire
        /// map evaluates to true.
        /// </para>
        /// </li> </ul> 
        /// <para>
        /// If you omit <i>ConditionalOperator</i>, then <code>AND</code> is the default.
        /// </para>
        ///  
        /// <para>
        /// The operation will succeed only if the entire map evaluates to true.
        /// </para>
        /// </summary>
        public ConditionalOperator ConditionalOperator
        {
            get { return this._conditionalOperator; }
            set { this._conditionalOperator = value; }
        }

        // Check to see if ConditionalOperator property is set
        internal bool IsSetConditionalOperator()
        {
            return this._conditionalOperator != null;
        }

        /// <summary>
        /// Gets and sets the property ConditionExpression. 
        /// <para>
        /// A condition that must be satisfied in order for a conditional <i>PutItem</i> operation
        /// to succeed.
        /// </para>
        ///  
        /// <para>
        /// An expression can contain any of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Boolean functions: <code>attribute_exists | attribute_not_exists | contains | begins_with</code>
        /// </para>
        ///  
        /// <para>
        /// These function names are case-sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Comparison operators: <code> = | &#x3C;&#x3E; | &#x3C; | &#x3E; | &#x3C;= | &#x3E;=
        /// | BETWEEN | IN</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Logical operators: <code>AND | OR | NOT</code>
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information on condition expressions, go to <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Expressions.SpecifyingConditions.html">Specifying
        /// Conditions</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        public string ConditionExpression
        {
            get { return this._conditionExpression; }
            set { this._conditionExpression = value; }
        }

        // Check to see if ConditionExpression property is set
        internal bool IsSetConditionExpression()
        {
            return this._conditionExpression != null;
        }

        /// <summary>
        /// Gets and sets the property Expected. <important> 
        /// <para>
        /// There is a newer parameter available. Use <i>ConditionExpression</i> instead. Note
        /// that if you use <i>Expected</i> and <i> ConditionExpression </i> at the same time,
        /// DynamoDB will return a <i>ValidationException</i> exception.
        /// </para>
        ///  
        /// <para>
        /// This parameter does not support lists or maps.
        /// </para>
        ///  </important> 
        /// <para>
        /// A map of attribute/condition pairs. <i>Expected</i> provides a conditional block for
        /// the <i>PutItem</i> operation.
        /// </para>
        ///  
        /// <para>
        /// Each element of <i>Expected</i> consists of an attribute name, a comparison operator,
        /// and one or more values. DynamoDB compares the attribute with the value(s) you supplied,
        /// using the comparison operator. For each <i>Expected</i> element, the result of the
        /// evaluation is either true or false.
        /// </para>
        ///  
        /// <para>
        /// If you specify more than one element in the <i>Expected</i> map, then by default all
        /// of the conditions must evaluate to true. In other words, the conditions are ANDed
        /// together. (You can use the <i>ConditionalOperator</i> parameter to OR the conditions
        /// instead. If you do this, then at least one of the conditions must evaluate to true,
        /// rather than all of them.)
        /// </para>
        ///  
        /// <para>
        /// If the <i>Expected</i> map evaluates to true, then the conditional operation succeeds;
        /// otherwise, it fails.
        /// </para>
        ///  
        /// <para>
        /// <i>Expected</i> contains the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <i>AttributeValueList</i> - One or more values to evaluate against the supplied attribute.
        /// The number of values in the list depends on the <i>ComparisonOperator</i> being used.
        /// </para>
        ///  
        /// <para>
        /// For type Number, value comparisons are numeric.
        /// </para>
        ///  
        /// <para>
        /// String value comparisons for greater than, equals, or less than are based on ASCII
        /// character code values. For example, <code>a</code> is greater than <code>A</code>,
        /// and <code>a</code> is greater than <code>B</code>. For a list of code values, see
        /// <a href="http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters" >http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters</a>.
        /// </para>
        ///  
        /// <para>
        /// For type Binary, DynamoDB treats each byte of the binary data as unsigned when it
        /// compares binary values, for example when evaluating query expressions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <i>ComparisonOperator</i> - A comparator for evaluating attributes in the <i>AttributeValueList</i>.
        /// When performing the comparison, DynamoDB uses strongly consistent reads.
        /// </para>
        ///  
        /// <para>
        /// The following comparison operators are available:
        /// </para>
        ///  
        /// <para>
        /// <code>EQ | NE | LE | LT | GE | GT | NOT_NULL | NULL | CONTAINS | NOT_CONTAINS | BEGINS_WITH
        /// | IN | BETWEEN</code>
        /// </para>
        ///  
        /// <para>
        /// The following are descriptions of each comparison operator.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <code>EQ</code> : Equal. <code>EQ</code> is supported for all datatypes, including
        /// lists and maps.
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> element of type
        /// String, Number, Binary, String Set, Number Set, or Binary Set. If an item contains
        /// an <i>AttributeValue</i> element of a different type than the one specified in the
        /// request, the value does not match. For example, <code>{"S":"6"}</code> does not equal
        /// <code>{"N":"6"}</code>. Also, <code>{"N":"6"}</code> does not equal <code>{"NS":["6",
        /// "2", "1"]}</code>.
        /// </para>
        ///  <p/> </li> <li> 
        /// <para>
        /// <code>NE</code> : Not equal. <code>NE</code> is supported for all datatypes, including
        /// lists and maps.
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String,
        /// Number, Binary, String Set, Number Set, or Binary Set. If an item contains an <i>AttributeValue</i>
        /// of a different type than the one specified in the request, the value does not match.
        /// For example, <code>{"S":"6"}</code> does not equal <code>{"N":"6"}</code>. Also, <code>{"N":"6"}</code>
        /// does not equal <code>{"NS":["6", "2", "1"]}</code>.
        /// </para>
        ///  <p/> </li> <li> 
        /// <para>
        /// <code>LE</code> : Less than or equal. 
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> element of type
        /// String, Number, or Binary (not a set type). If an item contains an <i>AttributeValue</i>
        /// element of a different type than the one specified in the request, the value does
        /// not match. For example, <code>{"S":"6"}</code> does not equal <code>{"N":"6"}</code>.
        /// Also, <code>{"N":"6"}</code> does not compare to <code>{"NS":["6", "2", "1"]}</code>.
        /// </para>
        ///  <p/> </li> <li> 
        /// <para>
        /// <code>LT</code> : Less than. 
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String,
        /// Number, or Binary (not a set type). If an item contains an <i>AttributeValue</i> element
        /// of a different type than the one specified in the request, the value does not match.
        /// For example, <code>{"S":"6"}</code> does not equal <code>{"N":"6"}</code>. Also, <code>{"N":"6"}</code>
        /// does not compare to <code>{"NS":["6", "2", "1"]}</code>.
        /// </para>
        ///  <p/> </li> <li> 
        /// <para>
        /// <code>GE</code> : Greater than or equal. 
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> element of type
        /// String, Number, or Binary (not a set type). If an item contains an <i>AttributeValue</i>
        /// element of a different type than the one specified in the request, the value does
        /// not match. For example, <code>{"S":"6"}</code> does not equal <code>{"N":"6"}</code>.
        /// Also, <code>{"N":"6"}</code> does not compare to <code>{"NS":["6", "2", "1"]}</code>.
        /// </para>
        ///  <p/> </li> <li> 
        /// <para>
        /// <code>GT</code> : Greater than. 
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> element of type
        /// String, Number, or Binary (not a set type). If an item contains an <i>AttributeValue</i>
        /// element of a different type than the one specified in the request, the value does
        /// not match. For example, <code>{"S":"6"}</code> does not equal <code>{"N":"6"}</code>.
        /// Also, <code>{"N":"6"}</code> does not compare to <code>{"NS":["6", "2", "1"]}</code>.
        /// </para>
        ///  <p/> </li> <li> 
        /// <para>
        /// <code>NOT_NULL</code> : The attribute exists. <code>NOT_NULL</code> is supported for
        /// all datatypes, including lists and maps.
        /// </para>
        ///  <note>
        /// <para>
        /// This operator tests for the existence of an attribute, not its data type. If the data
        /// type of attribute "<code>a</code>" is null, and you evaluate it using <code>NOT_NULL</code>,
        /// the result is a Boolean <i>true</i>. This result is because the attribute "<code>a</code>"
        /// exists; its data type is not relevant to the <code>NOT_NULL</code> comparison operator.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// <code>NULL</code> : The attribute does not exist. <code>NULL</code> is supported for
        /// all datatypes, including lists and maps.
        /// </para>
        ///  <note>
        /// <para>
        /// This operator tests for the nonexistence of an attribute, not its data type. If the
        /// data type of attribute "<code>a</code>" is null, and you evaluate it using <code>NULL</code>,
        /// the result is a Boolean <i>false</i>. This is because the attribute "<code>a</code>"
        /// exists; its data type is not relevant to the <code>NULL</code> comparison operator.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// <code>CONTAINS</code> : Checks for a subsequence, or value in a set.
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> element of type
        /// String, Number, or Binary (not a set type). If the target attribute of the comparison
        /// is of type String, then the operator checks for a substring match. If the target attribute
        /// of the comparison is of type Binary, then the operator looks for a subsequence of
        /// the target that matches the input. If the target attribute of the comparison is a
        /// set ("<code>SS</code>", "<code>NS</code>", or "<code>BS</code>"), then the operator
        /// evaluates to true if it finds an exact match with any member of the set.
        /// </para>
        ///  
        /// <para>
        /// CONTAINS is supported for lists: When evaluating "<code>a CONTAINS b</code>", "<code>a</code>"
        /// can be a list; however, "<code>b</code>" cannot be a set, a map, or a list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>NOT_CONTAINS</code> : Checks for absence of a subsequence, or absence of a value
        /// in a set.
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> element of type
        /// String, Number, or Binary (not a set type). If the target attribute of the comparison
        /// is a String, then the operator checks for the absence of a substring match. If the
        /// target attribute of the comparison is Binary, then the operator checks for the absence
        /// of a subsequence of the target that matches the input. If the target attribute of
        /// the comparison is a set ("<code>SS</code>", "<code>NS</code>", or "<code>BS</code>"),
        /// then the operator evaluates to true if it <i>does not</i> find an exact match with
        /// any member of the set.
        /// </para>
        ///  
        /// <para>
        /// NOT_CONTAINS is supported for lists: When evaluating "<code>a NOT CONTAINS b</code>",
        /// "<code>a</code>" can be a list; however, "<code>b</code>" cannot be a set, a map,
        /// or a list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>BEGINS_WITH</code> : Checks for a prefix. 
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String
        /// or Binary (not a Number or a set type). The target attribute of the comparison must
        /// be of type String or Binary (not a Number or a set type).
        /// </para>
        ///  <p/> </li> <li> 
        /// <para>
        /// <code>IN</code> : Checks for matching elements within two sets.
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> can contain one or more <i>AttributeValue</i> elements of
        /// type String, Number, or Binary (not a set type). These attributes are compared against
        /// an existing set type attribute of an item. If any elements of the input set are present
        /// in the item attribute, the expression evaluates to true.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>BETWEEN</code> : Greater than or equal to the first value, and less than or
        /// equal to the second value. 
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> must contain two <i>AttributeValue</i> elements of the same
        /// type, either String, Number, or Binary (not a set type). A target attribute matches
        /// if the target value is greater than, or equal to, the first element and less than,
        /// or equal to, the second element. If an item contains an <i>AttributeValue</i> element
        /// of a different type than the one specified in the request, the value does not match.
        /// For example, <code>{"S":"6"}</code> does not compare to <code>{"N":"6"}</code>. Also,
        /// <code>{"N":"6"}</code> does not compare to <code>{"NS":["6", "2", "1"]}</code>
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For usage examples of <i>AttributeValueList</i> and <i>ComparisonOperator</i>, see
        /// <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/LegacyConditionalParameters.html">Legacy
        /// Conditional Parameters</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For backward compatibility with previous DynamoDB releases, the following parameters
        /// can be used instead of <i>AttributeValueList</i> and <i>ComparisonOperator</i>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <i>Value</i> - A value for DynamoDB to compare with an attribute.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <i>Exists</i> - A Boolean value that causes DynamoDB to evaluate the value before
        /// attempting the conditional operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <i>Exists</i> is <code>true</code>, DynamoDB will check to see if that attribute
        /// value already exists in the table. If it is found, then the condition evaluates to
        /// true; otherwise the condition evaluate to false.
        /// </para>
        ///  </li> <li>
        /// <para>
        /// If <i>Exists</i> is <code>false</code>, DynamoDB assumes that the attribute value
        /// does <i>not</i> exist in the table. If in fact the value does not exist, then the
        /// assumption is valid and the condition evaluates to true. If the value is found, despite
        /// the assumption that it does not exist, the condition evaluates to false.
        /// </para>
        /// </li> </ul> </li> 
        /// <para>
        /// Note that the default value for <i>Exists</i> is <code>true</code>.
        /// </para>
        ///  </ul> 
        /// <para>
        /// The <i>Value</i> and <i>Exists</i> parameters are incompatible with <i>AttributeValueList</i>
        /// and <i>ComparisonOperator</i>. Note that if you use both sets of parameters at once,
        /// DynamoDB will return a <i>ValidationException</i> exception.
        /// </para>
        /// </summary>
        public Dictionary<string, ExpectedAttributeValue> Expected
        {
            get { return this._expected; }
            set { this._expected = value; }
        }

        // Check to see if Expected property is set
        internal bool IsSetExpected()
        {
            return this._expected != null && this._expected.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExpressionAttributeNames. 
        /// <para>
        /// One or more substitution tokens for simplifying complex expressions. The following
        /// are some use cases for using <i>ExpressionAttributeNames</i>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To shorten an attribute name that is very long or unwieldy in an expression.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a placeholder for repeating occurrences of an attribute name in an expression.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To prevent special characters in an attribute name from being misinterpreted in an
        /// expression.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Use the <b>#</b> character in an expression to dereference an attribute name. For
        /// example, consider the following expression:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// <code>order.customerInfo.LastName = "Smith" OR order.customerInfo.LastName = "Jones"</code>
        /// </para>
        /// </li></ul> 
        /// <para>
        /// Now suppose that you specified the following for <i>ExpressionAttributeNames</i>:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// <code>{"#name":"order.customerInfo.LastName"}</code>
        /// </para>
        /// </li></ul> 
        /// <para>
        /// The expression can now be simplified as follows:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// <code>#name = "Smith" OR #name = "Jones"</code>
        /// </para>
        /// </li></ul> 
        /// <para>
        /// For more information on expression attribute names, go to <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Expressions.AccessingItemAttributes.html">Accessing
        /// Item Attributes</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> ExpressionAttributeNames
        {
            get { return this._expressionAttributeNames; }
            set { this._expressionAttributeNames = value; }
        }

        // Check to see if ExpressionAttributeNames property is set
        internal bool IsSetExpressionAttributeNames()
        {
            return this._expressionAttributeNames != null && this._expressionAttributeNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExpressionAttributeValues. 
        /// <para>
        /// One or more values that can be substituted in an expression.
        /// </para>
        ///  
        /// <para>
        /// Use the <b>:</b> (colon) character in an expression to dereference an attribute value.
        /// For example, suppose that you wanted to check whether the value of the <i>ProductStatus</i>
        /// attribute was one of the following: 
        /// </para>
        ///  
        /// <para>
        /// <code>Available | Backordered | Discontinued</code>
        /// </para>
        ///  
        /// <para>
        /// You would first need to specify <i>ExpressionAttributeValues</i> as follows:
        /// </para>
        ///  
        /// <para>
        /// <code>{ ":avail":{"S":"Available"}, ":back":{"S":"Backordered"}, ":disc":{"S":"Discontinued"}
        /// }</code>
        /// </para>
        ///  
        /// <para>
        /// You could then use these values in an expression, such as this:
        /// </para>
        ///  
        /// <para>
        /// <code>ProductStatus IN (:avail, :back, :disc)</code>
        /// </para>
        ///  
        /// <para>
        /// For more information on expression attribute values, go to <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Expressions.SpecifyingConditions.html">Specifying
        /// Conditions</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        public Dictionary<string, AttributeValue> ExpressionAttributeValues
        {
            get { return this._expressionAttributeValues; }
            set { this._expressionAttributeValues = value; }
        }

        // Check to see if ExpressionAttributeValues property is set
        internal bool IsSetExpressionAttributeValues()
        {
            return this._expressionAttributeValues != null && this._expressionAttributeValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Item. 
        /// <para>
        /// A map of attribute name/value pairs, one for each attribute. Only the primary key
        /// attributes are required; you can optionally provide other attribute name-value pairs
        /// for the item.
        /// </para>
        ///  
        /// <para>
        /// You must provide all of the attributes for the primary key. For example, with a hash
        /// type primary key, you only need to specify the hash attribute. For a hash-and-range
        /// type primary key, you must specify both the hash attribute and the range attribute.
        /// </para>
        ///  
        /// <para>
        /// If you specify any attributes that are part of an index key, then the data types for
        /// those attributes must match those of the schema in the table's attribute definition.
        /// </para>
        ///  
        /// <para>
        /// For more information about primary keys, see <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/DataModel.html#DataModelPrimaryKey">Primary
        /// Key</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Each element in the <i>Item</i> map is an <i>AttributeValue</i> object.
        /// </para>
        /// </summary>
        public Dictionary<string, AttributeValue> Item
        {
            get { return this._item; }
            set { this._item = value; }
        }

        // Check to see if Item property is set
        internal bool IsSetItem()
        {
            return this._item != null && this._item.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReturnConsumedCapacity.
        /// </summary>
        public ReturnConsumedCapacity ReturnConsumedCapacity
        {
            get { return this._returnConsumedCapacity; }
            set { this._returnConsumedCapacity = value; }
        }

        // Check to see if ReturnConsumedCapacity property is set
        internal bool IsSetReturnConsumedCapacity()
        {
            return this._returnConsumedCapacity != null;
        }

        /// <summary>
        /// Gets and sets the property ReturnItemCollectionMetrics. 
        /// <para>
        /// A value that if set to <code>SIZE</code>, the response includes statistics about item
        /// collections, if any, that were modified during the operation are returned in the response.
        /// If set to <code>NONE</code> (the default), no statistics are returned.
        /// </para>
        /// </summary>
        public ReturnItemCollectionMetrics ReturnItemCollectionMetrics
        {
            get { return this._returnItemCollectionMetrics; }
            set { this._returnItemCollectionMetrics = value; }
        }

        // Check to see if ReturnItemCollectionMetrics property is set
        internal bool IsSetReturnItemCollectionMetrics()
        {
            return this._returnItemCollectionMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property ReturnValues. 
        /// <para>
        /// Use <i>ReturnValues</i> if you want to get the item attributes as they appeared before
        /// they were updated with the <i>PutItem</i> request. For <i>PutItem</i>, the valid values
        /// are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <code>NONE</code> - If <i>ReturnValues</i> is not specified, or if its value is <code>NONE</code>,
        /// then nothing is returned. (This setting is the default for <i>ReturnValues</i>.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>ALL_OLD</code> - If <i>PutItem</i> overwrote an attribute name-value pair, then
        /// the content of the old item is returned.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ReturnValue ReturnValues
        {
            get { return this._returnValues; }
            set { this._returnValues = value; }
        }

        // Check to see if ReturnValues property is set
        internal bool IsSetReturnValues()
        {
            return this._returnValues != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table to contain the item.
        /// </para>
        /// </summary>
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

    }
}